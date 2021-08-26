using Microsoft.AspNetCore.Identity;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Entities.AuthModel;
using OngProject.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface IUserService
    {
        Task<GenericResult<IEnumerable<UserGetAllDto>>> GetAll();
        Task<IdentityResult> Insert(User entity);
        Task<UserManagerResponse> Update(UserUpdateDto entity, ClaimsPrincipal user);
        Task<UserManagerResponse> Delete(string id);
    }
}
