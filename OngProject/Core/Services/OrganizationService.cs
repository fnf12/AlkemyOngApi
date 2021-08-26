using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IRepositories;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrganizationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<OrganizationDto>> GetAll()
        {

            var organization = await _unitOfWork.OrganizationRepository.GetAll();
            EntityMapper mapper = new();

            var organizationDtoList = organization.Select(x => mapper.FromOrganizationToOrganizationDto(x)).ToList();
            return organizationDtoList;

        }

        public async Task<OrganizationDto> GetById(int id)
        {
            var organization = await _unitOfWork.OrganizationRepository.GetById(id);
            EntityMapper maper = new();
            var organizationDto = maper.FromOrganizationToOrganizationDto(organization);
            return organizationDto;
        }

        public async Task Insert(Organization entity)
        {
            await _unitOfWork.OrganizationRepository.Insert(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> Update(Organization entity)
        {
           
            await _unitOfWork.OrganizationRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.OrganizationRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePublicProperties(int id, OrganizationDto organizationDto)
        {

            var organizationExists = await _unitOfWork.OrganizationRepository.GetAll();
            if (organizationExists.Count() != 1)
                throw new KeyNotFoundException();



            try
            {
                if (_unitOfWork.OrganizationRepository.EntityExists(id))
                {
                    var organization = await _unitOfWork.OrganizationRepository.GetById(id);
                    if (organizationDto.Name != null)
                        organization.Name = organizationDto.Name;
                    if (organizationDto.LinkedInUrl != null)
                        organization.LinkedInUrl = organizationDto.LinkedInUrl;
                    if (organizationDto.InstagramUrl != null)
                        organization.InstagramUrl = organizationDto.InstagramUrl;
                    if (organizationDto.FacebookUrl != null)
                        organization.FacebookUrl = organizationDto.FacebookUrl;
                    if (organizationDto.Phone != null)
                        organization.Phone = organization.Phone;
                    if (organizationDto.WelcomeText != null)
                        organization.WelcomeText = organization.WelcomeText;
                    if (organizationDto.AboutUsText != null)
                        organization.AboutUsText = organization.AboutUsText;
                    if (organizationDto.Address != null)
                        organization.Address = organization.Address;
                    if (organizationDto.Email != null)
                        organization.Email = organization.Email;
                    
                   
                    if (organizationDto.Image != null)
                    {
                        if (ValidateFiles.ValidateImage(organizationDto.Image))
                        {
                            var s3helper = new S3AwsHelper();
                            var result = await s3helper.AwsUploadFile(Guid.NewGuid().ToString(), organizationDto.Image);
                            if (result.Code == 200)
                            {
                                organization.Image = result.Url;
                                await _unitOfWork.OrganizationRepository.Update(organization);
                                await _unitOfWork.SaveChangesAsync();
                                return true;
                            }
                            else
                                throw new Exception(result.Errors);
                        }
                        else
                            throw new Exception("Image not valid");
                    }
                    else
                    {
                        await _unitOfWork.OrganizationRepository.Update(organization);
                        await _unitOfWork.SaveChangesAsync();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }


          

        }

        public GenericResult<OrgWithSlidesDto> GetOrganizationWithSlides()
        {
            try
            {
                var org = _unitOfWork.OrganizationRepository.GetAll().Result.FirstOrDefault();

                var _slides = _unitOfWork.SlideRepository.GetAll().Result.ToList().Where(x => x.OrganizationId == org.Id).OrderBy(x => x.Order).ToList();

                var slides = _slides.Select(x => new SlideOrgDto
                    {
                        Id = x.Id,
                        Text = x.Text,
                        ImageUrl = x.ImageUrl,
                        Order = x.Order
                    });

                OrgWithSlidesDto _org = new OrgWithSlidesDto
                {
                    Name = org.Name,
                    Image = org.Image,
                    Address = org.Address,
                    Phone = org.Phone,
                    FacebookUrl = org.FacebookUrl,
                    InstagramUrl = org.InstagramUrl,
                    LinkedInUrl = org.LinkedInUrl,
                    Slides = slides
                };

                return new GenericResult<OrgWithSlidesDto>(null)
                {
                    Message = "Get Succes",
                    IsSuccess = true,
                    _object = _org
                };
            }
            catch (Exception e)
            {
                return new GenericResult<OrgWithSlidesDto>(null)
                {
                    IsSuccess = false,
                    Message = e.Message
                };
            }
        }


    }
}
