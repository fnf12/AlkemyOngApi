using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IServices.IGetUri;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUriService _uriService;

        public ActivityService(IUnitOfWork unitOfWork, IUriService uriService)
        {
            _unitOfWork = unitOfWork;
            _uriService = uriService;
        }

        public async Task<bool> DeleteActivity(int id)
        {
            await _unitOfWork.ActivityRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<Activity> GetActivityById(int id)
        {
            return await _unitOfWork.ActivityRepository.GetById(id);
        }

        public async Task<IEnumerable<Activity>> GetAllActivities()
        {
            return await _unitOfWork.ActivityRepository.GetAll();
        }

        public async Task<GenericResult<ActivityDto>> InsertActivity(ActivityInsertDto entity)
        {
            try
            {
                Activity activity = new Activity();
                AwsManagerResponse imageResult = new AwsManagerResponse();
                var s3helper = new S3AwsHelper();
                EntityMapper map = new EntityMapper();
                if (entity.Image != null && ValidateFiles.ValidateImage(entity.Image))
                {
                    var id = Guid.NewGuid().ToString();
                    imageResult = await s3helper.AwsUploadFile(id, entity.Image);
                    if (imageResult.Code == 200)
                    {
                        activity.Image = imageResult.Url;
                        activity.Content = entity.Content;
                        activity.Name = entity.Name;
                        await _unitOfWork.ActivityRepository.Insert(activity);
                        await _unitOfWork.SaveChangesAsync();
                        var dto = map.FromActivityToActivityDTO(activity);
                        return new GenericResult<ActivityDto>(dto)
                        {
                            IsSuccess = true,
                            Message = "Activity created succesfully",

                        }; 
                    }
                    else
                    {
                        return new GenericResult<ActivityDto>(null)
                        {
                            IsSuccess = false,
                            Message = "Activity creation error. Image not created, try again" + imageResult.Errors
                        };
                    }
                }
                return new GenericResult<ActivityDto>(null)
                {
                    IsSuccess = false,
                    Message = "Image extension not valid"
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GenericResult<ActivityDto>> UpdateActivity(int id, ActivityUpdateDto activityUpdateDto)
        {
            try
            {
                var activity = await _unitOfWork.ActivityRepository.GetById(id);
                activity.Name = activityUpdateDto.Name;
                activity.Content = activityUpdateDto.Content;

                if (activityUpdateDto.Image != null)
                {
                    if (ValidateFiles.ValidateImage(activityUpdateDto.Image))
                    {
                        var s3helper = new S3AwsHelper();
                        EntityMapper map = new EntityMapper();
                        var result = await s3helper.AwsUploadFile(Guid.NewGuid().ToString(), activityUpdateDto.Image);
                        if (result.Code == 200)
                        {
                            activity.Image = result.Url;
                            await _unitOfWork.ActivityRepository.Update(activity);
                            await _unitOfWork.SaveChangesAsync();
                            var dto = map.FromActivityToActivityDTO(activity);
                            return new GenericResult<ActivityDto>(dto)
                            {
                                IsSuccess = true,
                                Message = "Updated succesfully",
                            };
                        }
                        else
                            return new GenericResult<ActivityDto>(null)
                            {
                                IsSuccess = false,
                                Message = result.Errors
                            };
                    }
                    else
                        return new GenericResult<ActivityDto>(null)
                        {
                            IsSuccess = false,
                            Message = "Image format not valid"
                        };
                }
                else
                {
                    return new GenericResult<ActivityDto>(null)
                    {
                        IsSuccess = false,
                        Message = "Activity must not be null"
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EntityExists(int id)
        {
            return _unitOfWork.ActivityRepository.EntityExists(id);
        }

    }
}


