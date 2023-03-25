using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Xml.Linq;

namespace RestAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class APICommentController : ControllerBase, IAPICommentController
    {
        private ICommentDataAccess _dataAccess;
        
        public APICommentController(ICommentDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }


        [HttpPost]
        public ActionResult AddComment(Comment comment)
        {
            return Ok(_dataAccess.AddComment(comment));
        }


        [HttpGet("{postedAt}/{username}")]
        public ActionResult<IEnumerable<Comment>> Comments(DateTime postedAt, String username)
        {
            IEnumerable<Comment> returnList =_dataAccess.GetAll(postedAt, username);
            return new ActionResult<IEnumerable<Comment>>(returnList);
        }


        [HttpDelete]
        public ActionResult DeleteComment(DateTime dateTimeComment, string username)
        {
            Comment comment = new Comment() { DateTime = dateTimeComment, Username = username };
            _dataAccess.DeleteComment(comment);
            return Ok();
        }


        [HttpPut]
        public ActionResult UpdateComment(Comment comment)
        {
            _dataAccess.UpdateComment(comment);
            return Ok();
        }
    }
}
