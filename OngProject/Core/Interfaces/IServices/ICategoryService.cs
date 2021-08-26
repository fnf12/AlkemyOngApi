using OngProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OngProject.Core.DTOs;
using OngProject.Core.Helper.Pagination;

namespace OngProject.Core.Interfaces.IServices
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryById(int id);
        Task<ResponsePagination<GenericPagination<Category>>> GetCategories(int page, int size,string controller);
        Task<Category> InsertCategory(CategoryCreateDto categoryCreateDto);
        Task<Category> UpdateCategory(int id, CategoryUpdateDto categoryUpdateDto);
        Task<bool> DeleteCategory(int id);
        bool EntityExists(int id);
    }
}
