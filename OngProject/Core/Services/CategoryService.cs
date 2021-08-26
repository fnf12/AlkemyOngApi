using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper;
using OngProject.Core.Helper.Pagination;
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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUriService _uriService;

        public CategoryService(IUnitOfWork unitOfWork, IUriService uriService)
        {
            _unitOfWork = unitOfWork;
            _uriService = uriService;
        }

        public async Task<Category> InsertCategory(CategoryCreateDto categoryCreateDto)
        {
            try
            {
                var cate =  _unitOfWork.CategoryRepository.GetAll().Result.ToList().SingleOrDefault(x => x.Name == categoryCreateDto.Name);
                if (cate != null)
                {
                    return null;
                }
                    var map = new EntityMapper();
                    var category = map.FromCategoryCreateDtoToCategory(categoryCreateDto);
                if (categoryCreateDto.Image != null)
                {
                    var s3helper = new S3AwsHelper();
                    string key = DateTime.Now.ToString();
                    key = key.Replace(":", "");
                    key = key.Replace("/", "");
                    key = key.Replace(" ", "");
                    var result = await s3helper.AwsUploadFile("category_" + key, categoryCreateDto.Image);

                    if (result.Code == 200)
                    {
                        category.Image = result.Url;
                    }
                    else
                        throw new Exception(result.Errors);
                }

                await _unitOfWork.CategoryRepository.Insert(category);
                await _unitOfWork.SaveChangesAsync();
                return (category);

            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<ResponsePagination<GenericPagination<Category>>> GetCategories(int page, int size, string controller)
        {
            var category = await _unitOfWork.CategoryRepository.GetAll();

            size = size == 0 ? 10 : size;
            page = page == 0 ? 1 : page;
            string rutaSiguiente = $"{controller}/?page={(page + 1)}";
            string rutaAnterior = $"{controller}/?page={(page - 1)}";


            //get a page(entity, NumberPage, PageSize)
            var pageCategories = GenericPagination<Category>.Create(category, page, size);

            //response with necessary information 
            ResponsePagination<GenericPagination<Category>> result = new ResponsePagination<GenericPagination<Category>>(pageCategories)
            {
                TotalRecords = pageCategories.TotalRecords,
                PageSize = pageCategories.PageSize,
                CurrentPage = pageCategories.CurrentPage,
                TotalPages = pageCategories.TotalPages,
                HasNextPage = pageCategories.HasNextPage,
                HasPreviousPage = pageCategories.HasPreviousPage,
            };

            //setUrls
            if (result.HasNextPage)
            {
                result.NextPageUrl = _uriService.GetPaginationUri(page, rutaSiguiente).ToString();
            }

            if (result.HasPreviousPage)
            {
                result.PreviousPageUrl = _uriService.GetPaginationUri(page, rutaAnterior).ToString();
            }

            return result;
        }


        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _unitOfWork.CategoryRepository.GetById(id);
            if (!category.IsDeleted)
                return category;
            else
                return null;
        }
        public async Task<Category> UpdateCategory(int id, CategoryUpdateDto categoryUpdateDto)
        {
            try
            {
                if (_unitOfWork.CategoryRepository.EntityExists(id))
                {
                    var category = await GetCategoryById(id);
                    if (category == null)
                        return null;
                    category.Description = categoryUpdateDto.Description;
                    category.Name = categoryUpdateDto.Name;

                    if (categoryUpdateDto.Image != null)
                    {
                        if (ValidateFiles.ValidateImage(categoryUpdateDto.Image))
                        {
                            S3AwsHelper s3helper = new S3AwsHelper();
                            AwsManagerResponse result = await s3helper.AwsUploadFile(category.Image.Substring(category.Image.IndexOf("category_")), categoryUpdateDto.Image);
                            if (result.Code == 200)
                            {
                                await _unitOfWork.CategoryRepository.Update(category);
                                await _unitOfWork.SaveChangesAsync();
                                return category;
                            }
                            else
                            {
                                throw new Exception(result.Errors);
                            }
                        }
                        else
                        {
                            throw new Exception("Image not valid");
                        }
                    }
                    else
                    {
                        await _unitOfWork.CategoryRepository.Update(category);
                        await _unitOfWork.SaveChangesAsync();
                        return category;
                    }
                }
                throw new Exception("Category not found.");
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task<bool> DeleteCategory(int id)
        {
            if (await GetCategoryById(id) != null)
            {
                await _unitOfWork.CategoryRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public bool EntityExists(int id)
        {
            return _unitOfWork.CategoryRepository.EntityExists(id);
        }
    }
}






