using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    public interface IAPICommentController
    {
        ActionResult AddComment(Comment comment);
        ActionResult<IEnumerable<Comment>> Comments(DateTime postedAt, String username);
        public ActionResult UpdateComment(Comment comment);
        public ActionResult DeleteComment(DateTime dateTimeComment, string username);
    }
}
