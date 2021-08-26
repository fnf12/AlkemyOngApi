using System.Collections.Generic;
using System.Threading.Tasks;
using OngProject.Core.Entities;
using OngProject.Core.Interfaces.IServices;
using OngProject.Core.Interfaces.IUnitOfWork;
using System.Linq;
using OngProject.Core.DTOs;
using OngProject.Core.Mapper;
using System.Security.Claims;
using System;
using OngProject.Core.Helper;

namespace OngProject.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<CommentDto> GetCommentByPost(int id)
        {
            var mapper = new EntityMapper();
            var commentList = _unitOfWork.CommentRepository.GetAll().Result.Where(x => x.PostId == id);
            var commentDtoList = mapper.FromCommentListToCommentDtoList(commentList);
            return commentDtoList.OrderBy(x => x.CreatedAt);
        }

        public async Task<IEnumerable<CommentDto>> GetComments()
        {
            var mapper = new EntityMapper();
            var commentList = await _unitOfWork.CommentRepository.GetAll();
            var commentDtoList = mapper.FromCommentListToCommentDtoList(commentList);
            return commentDtoList.OrderBy(x => x.CreatedAt);
        }
        public async Task<Comment> GetComment(int id)
        {
            return await _unitOfWork.CommentRepository.GetById(id);
        }

        public async Task<GenericResult<CommentDto>> InsertComment(CommentInsertDto comment, ClaimsPrincipal user)
        {
            try
            {
                var userid = user.Claims.Where(x => x.Type == "UserId").FirstOrDefault()?.Value;
                if (_unitOfWork.NewsRepository.EntityExists(comment.NewsId))
                {
                    Comment _comment = new Comment
                    {
                        PostId = comment.NewsId,
                        Body = comment.Body,
                        UserId = userid
                    };
                    await _unitOfWork.CommentRepository.Insert(_comment);
                    await _unitOfWork.SaveChangesAsync();
                    var dto = new EntityMapper().FromCommentToCommentDto(_comment);
                    return new GenericResult<CommentDto>(dto)
                    {
                        IsSuccess = true,
                        Message = "Comment created"
                    };
                }
                return new GenericResult<CommentDto>(null)
                {
                    IsSuccess = false,
                    Message = "News id not found"
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GenericResult<CommentDto>> UpdateComment(int id, CommentUpdateDto commentDto)
        {
            try
            {
                if (id != commentDto.Id)
                {
                    return new GenericResult<CommentDto>(null)
                    {
                        IsSuccess = false,
                        Message = "request id and commentId are not equal"
                    };
                }
                var _comment = await _unitOfWork.CommentRepository.GetById(id);
                _comment.Body = commentDto.Body;
                await _unitOfWork.CommentRepository.Update(_comment);
                await _unitOfWork.SaveChangesAsync();
                var dto = new EntityMapper().FromCommentToCommentDto(_comment);
                return new GenericResult<CommentDto>(dto)
                {
                    IsSuccess = true,
                    Message = "Updated succesfully!"
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteComment(int id)
        {
            await _unitOfWork.CommentRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ValidateCreatorOrAdminAsync(ClaimsPrincipal user, int id)
        {
            var userid = user.Claims.Where(x => x.Type == "UserId").FirstOrDefault()?.Value;

            Comment comment = await _unitOfWork.CommentRepository.GetById(id);

            if (comment == null)
            {
                return false;
            }

            if (comment.UserId.Equals(userid) || user.IsInRole("Admin"))
            {
                return true;
            }

            return false;
        }

        public bool EntityExists(int id)
        {
            return _unitOfWork.CommentRepository.EntityExists(id);
        }


    }
}