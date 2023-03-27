using Client.Controllers;
using Client.Models;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Webserver__MVC_.Controllers
{
    public class PostController : Controller
    {
        private ClientPost _client = new ClientPost("https://localhost:7146/api/APIPost");
        private static String tempCategoryName = null;
        // GET: PostController
        public ActionResult Posts([FromQuery] String CategoryName)
        {
            if (CategoryName == null)
            {
                CategoryName = tempCategoryName;
            }
            else
            {
                tempCategoryName = CategoryName;
                TempData["categoryName"] = CategoryName;
            }

            List<PostClient> postsToFind = _client.Posts(CategoryName).ToList();


            return View(postsToFind);
        }

        // GET: PostController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<PostClient> Create(PostClient postForCreate)
        {
            string x = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            postForCreate.TimeOfPost = DateTime.Parse(x);
            postForCreate.TopicCategoryName = tempCategoryName;
            try
            {
                _client.InsertPost(postForCreate);
                return RedirectToAction(nameof(Posts));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult<Post> Edit(PostClient post)
        {
            string time = post.TimeOfPost.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("en-US", true));
            post.TimeOfPost = DateTime.Parse(time);
            PostClient postForUpdate = _client.GetPost(post);
            TempData["PostTime"] = time;

            return View(postForUpdate);
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName ("Edit")]
        public ActionResult EditPost(PostClient post)
        {
            try
            {
                _client.UpdatePost(post);
                return RedirectToAction(nameof(Posts));
            }
            catch
            {
                return View();
            }

        }

        // GET: PostController/Delete/5
        public ActionResult Delete(DateTime timeOfPost, String username, string topicCategoryName)
        {
            PostClient postToDelete = new PostClient();

            foreach (PostClient postInList in _client.Posts(topicCategoryName))
            {
                if (postInList.Username.Equals(username) && postInList.TimeOfPost == timeOfPost)
                {
                    postToDelete.Username = postInList.Username;
                    postToDelete.Title = postInList.Title;
                    postToDelete.Text = postInList.Text;
                    postToDelete.TimeOfPost = postInList.TimeOfPost;
                    postToDelete.TopicCategoryName = postInList.TopicCategoryName;
                }
            }
            return View(postToDelete);
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PostClient post)
        {
            try
            {
                _client.DeletePost(post);
                return RedirectToAction(nameof(Posts));
            }
            catch
            {
                return View();
            }
        }
    }
}
