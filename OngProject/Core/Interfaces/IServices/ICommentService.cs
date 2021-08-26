using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using OngProject.Core.DTOs;
using OngProject.Core.Entities;
using OngProject.Core.Helper;

namespace OngProject.Core.Interfaces.IServices
{
    public interface ICommentService
    {
        IEnumerable<CommentDto> GetCommentByPost(int id);
        Task<IEnumerable<CommentDto>> GetComments();
        Task<Comment> GetComment(int id);
        Task<GenericResult<CommentDto>> InsertComment(CommentInsertDto comment, ClaimsPrincipal user);
        Task<GenericResult<CommentDto>> UpdateComment(int id, CommentUpdateDto commentDto);
        Task<bool> DeleteComment(int id);
        Task<bool> ValidateCreatorOrAdminAsync(ClaimsPrincipal user, int commentId);
        bool EntityExists(int id);
    }
}