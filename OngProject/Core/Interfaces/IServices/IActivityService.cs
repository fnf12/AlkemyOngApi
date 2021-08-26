using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Interfaces.IServices
{
    public interface IActivityService
    {
        Task<IEnumerable<Activity>> GetAllActivities();
        Task<Activity> GetActivityById(int id);
        Task<GenericResult<ActivityDto>> InsertActivity(ActivityInsertDto entity);
        Task<GenericResult<ActivityDto>> UpdateActivity(int id, ActivityUpdateDto activityUpdateDto);
        Task<bool> DeleteActivity(int id);
        public bool EntityExists(int id);

    }
}
