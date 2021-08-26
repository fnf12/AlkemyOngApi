using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Entities.AuthModel;
using OngProject.Core.Helper;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OngProject.Core.Services
{
    public class UserService : IUserService
    {
        private UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<GenericResult<IEnumerable<UserGetAllDto>>> GetAll()
        {
            var mapper = new EntityMapper();
            var users = await _userManager.Users.Where(x => x.IsDeleted == false).Select(x => mapper.FromUserToUserGetAllDto(x)).ToListAsync();
            var response = new GenericResult<IEnumerable<UserGetAllDto>>(users) { IsSuccess = true, Message = "Get All Users" };
            return response;
        }
        public async Task<IdentityResult> Insert(User entity)
        {
            var result = await _userManager.CreateAsync(entity);
            return result;
        }

        public async Task<UserManagerResponse> Update(UserUpdateDto entity, ClaimsPrincipal user)
        {
            try
            {
                AwsManagerResponse imageResult = new AwsManagerResponse(); ;
                var s3helper = new S3AwsHelper();
                var _userId = user.Claims.Where(x => x.Type == "UserId").FirstOrDefault()?.Value;
                User _user = await _userManager.FindByIdAsync(_userId);
                _user.FirstName = entity.FirstName;
                _user.LastName = entity.LastName;
                if (entity.Photo != null && ValidateFiles.ValidateImage(entity.Photo))
                {
                    var id = Guid.NewGuid().ToString();
                    imageResult = await s3helper.AwsUploadFile(id, entity.Photo);
                    _user.Photo = imageResult.Url;
                }
                var response = await _userManager.UpdateAsync(_user);
                var _UMresponse = new UserManagerResponse();
                if (response.Succeeded)
                {
                    _UMresponse.IsSuccess = true;
                    _UMresponse.Message = "User Updated!";
                    if (imageResult.Errors != null)
                    {
                        _UMresponse.Errors.Prepend(imageResult.Errors);
                    }
                }
                else
                {
                    _UMresponse.IsSuccess = false;
                    _UMresponse.Message = "Cant Update User";
                    _UMresponse.Errors = (IEnumerable<string>)response.Errors;
                }
                return _UMresponse;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserManagerResponse> Delete(string id)
        {
            try
            {
                var _UMresponse = new UserManagerResponse();
                if (string.IsNullOrEmpty(id))
                {
                    _UMresponse.IsSuccess = false;
                    _UMresponse.Message = "Error: Id is Null or Empty";
                    return _UMresponse;
                }
                
                var user = await _userManager.FindByIdAsync(id);
                if(user != null)
                {
                    user.IsDeleted = true;
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        _UMresponse.IsSuccess = true;
                        _UMresponse.Message = "User Deleted Succesfully";
                    }
                    else
                    {
                        _UMresponse.IsSuccess = false;
                        _UMresponse.Message = "Cant Delete User";
                        _UMresponse.Errors = (IEnumerable<string>)result.Errors;
                    }
                }
                else
                {
                    _UMresponse.IsSuccess = false;
                    _UMresponse.Message = "user id not found";
                }
                return _UMresponse;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
