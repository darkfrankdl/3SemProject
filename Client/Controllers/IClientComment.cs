using Client.Models;

namespace Client.Controllers
{
    public interface IClientComment
    {
        IEnumerable<CommentClient> Comments(DateTime time , string username);
        void DeleteComment(DateTime time, string username);
        void InsertComment(CommentClient comment);
        void UpdateComment(CommentClient comment);
    }
}