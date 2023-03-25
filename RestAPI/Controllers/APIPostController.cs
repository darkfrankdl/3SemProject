using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route ("api/[Controller]")]

    public class APIPostController : ControllerBase
    {
        private IPostDataAccess _dataAccess;

        public APIPostController(IPostDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetAll()
        {
            if (Ok(_dataAccess.GetAll()).StatusCode == 200)
            {
                return _dataAccess.GetAll().ToList();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("{categoryName}")]
        public ActionResult<IEnumerable<Post>> GetPostsFromTopicWithID(String? categoryName)
        {
            if (Ok(_dataAccess.GetPostsFromTopicWithID(categoryName)).StatusCode == 200)
            {
                return _dataAccess.GetPostsFromTopicWithID(categoryName).ToList();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        [Route("{postDateTime}/{postUsername}")]
        public ActionResult<Post> GetPost(string? postUsername, string postDateTime)
        {
            if (Ok(_dataAccess.GetPost(postUsername, postDateTime)).StatusCode == 200)
            {
                return _dataAccess.GetPost(postUsername, postDateTime);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        [Route("{TimeOfPost}/{Username}")]
        public ActionResult<int> AddPost(Post post)
        {
            int test = 0;
            if (Ok(_dataAccess.Insert(post)).StatusCode == 200)
            {
                return test = 200;
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPut]
        [Route("{TimeOfPost}/{Username}")]
        public ActionResult<bool> UpdatePost(Post post)
        {
            return Ok(_dataAccess.Update(post));
        }


        [HttpDelete]
        [Route("{timeOfPost}/{username}")]
        public ActionResult<bool> DeletePost(string timeOfPost, string username)
        {
            Post post = new Post() { TimeOfPost = DateTime.Parse(timeOfPost,new CultureInfo("en-Us",true)), Username = username };
            bool test = false;
            if (_dataAccess.Delete(post))
            {
                return test = true;
            }
            else
            {
                return NotFound();
            }

        }
    }
}