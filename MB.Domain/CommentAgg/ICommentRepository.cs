using System.Collections.Generic;
using _01_Framework.Infrastructure;
using MB.Application.Contracts.Comment;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository
    {
        void CreateAndSave(Comment entity);
        List<CommentViewModel> GetList();
        Comment Get(long id);
        void Save();
        //List<CommentViewModel> GetList();
    }
}