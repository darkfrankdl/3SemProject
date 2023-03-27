using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;
using RestAPI.Controllers;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Implementations;
using System.Globalization;
using Client.Controllers;
using Client.Models;

namespace Webserver__MVC_.Controllers
{
    public class CommentController : Controller
    {
        private static string s_tempPostTime = null;
        private static string s_tempPostUser = null;
        private IClientComment _client = new ClientComment("https://localhost:7146/api/APIComment");
        private IAPICommentController _api = new APICommentController(new CommentDAO());
        // GET: CommentControllerMVC
        public ActionResult Comments(DateTime TimeOfPost, string Username)
        {
            if (TimeOfPost.ToString().Equals("01-01-0001 00:00:00") && Username == null)
            {
                TimeOfPost = DateTime.Parse(s_tempPostTime);
                Username = s_tempPostUser;

            }
            else
            {
                string time = TimeOfPost.ToString("yyyy-MM-dd HH:mm:ss");
                TempData["posttime"] = time;
                TempData["postuser"] = Username;
                s_tempPostTime = time;
                s_tempPostUser = Username;
            }

            List<CommentClient> list = _client.Comments(TimeOfPost, Username).ToList();
            return View(list);
        }

        // GET: CommentControllerMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentControllerMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CommentClient comment)
        {
            DateTime postedAt = DateTime.Now;
            string time = postedAt.ToString("yyyy-MM-dd HH:mm:ss");
            comment.DateTime = DateTime.Parse(time);
            comment.PostUsername = s_tempPostUser;

            try
            {
                _client.InsertComment(comment);
                return RedirectToAction(nameof(Comments));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentControllerMVC/Edit/5
        public ActionResult Edit(Comment comment)
        {

            CommentClient forView = new CommentClient();
            List<CommentClient> list = _client.Comments(comment.PostDateTime, comment.PostUsername).ToList();
            foreach (CommentClient commentToFind in list)
            {
                if (commentToFind.DateTime == comment.DateTime)
                {
                    forView = commentToFind;
                    TempData["PostTime"] = comment.PostDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    TempData["CommentDateTime"] = comment.DateTime.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }

            return View(forView);
        }

        // POST: CommentControllerMVC/Edit/5
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditComment(CommentClient comment)
        {
            try
            {
                _client.UpdateComment(comment);
                return RedirectToAction(nameof(Comments));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommentControllerMVC/Delete/5

        public ActionResult Delete(CommentClient comment)
        {

            comment.PostDateTime = DateTime.Parse(s_tempPostTime);
            CommentClient forView = new CommentClient();
            List<CommentClient> list = _client.Comments(comment.PostDateTime, comment.PostUsername).ToList();
            foreach (CommentClient commentToFind in list)
            {
                if (commentToFind.Username.Equals(comment.Username) && commentToFind.DateTime == comment.DateTime)
                {
                    forView = commentToFind;
                }
            }
            return View(forView);
        }

        // POST: CommentControllerMVC/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteComment(CommentClient comment)
        {
            try
            {
                _client.DeleteComment(comment.DateTime, comment.Username);
                return RedirectToAction(nameof(Comments));
            }
            catch
            {
                return View();
            }
        }
    }
}
