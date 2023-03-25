using Microsoft.AspNetCore.Mvc;
using System.Drawing.Design;
using Client.Controllers;
using Client.Models;
using RestAPI.Controllers;
using DataAccessLayer.Implementations;
using DataAccessLayer.Models;

namespace Webserver__MVC_.Controllers
{

    public class TopicController : Controller
    {
        
        APITopicController apiTopicController = new APITopicController(new TopicDAO());
        ClientTopic _restClient = new ClientTopic("https://localhost:7146/api/APITopic");

        public ActionResult Topics() => View(_restClient.Topics());

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TopicClient topic)
        {
            try
            {
                _restClient.InsertTopic(topic);

                return RedirectToAction(nameof(Topics));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(String categoryName)
        {
            TopicClient t = new TopicClient();

            foreach (TopicClient topic in _restClient.Topics())
            {
                if (topic.CategoryName.Equals(categoryName))
                {
                    t.CategoryName = topic.CategoryName;
                    t.Username = topic.Username;
                }
            }
            return View(t);

        }

        [HttpPost]
        public ActionResult<TopicClient> Edit(TopicClient topic)
        {
            try
            {
                _restClient.UpdateTopic(topic);
                return RedirectToAction(nameof(Topics));
            }
            catch
            {
                return View();
            }

            //try
            //{
            //    apiTopicController.UpdateTopic(topic);
            //    return RedirectToAction(nameof(Topics));
            //}
            //catch
            //{
            //    return View();
            //}

        }


        //[Route("[controller]/[action]/{CategoryName}")]
        public ActionResult Delete(String CategoryName)
        {
            TopicClient topicToDelete = new();
            foreach (TopicClient topic in _restClient.Topics())
            {
                if (topic.CategoryName.Equals(CategoryName))
                {
                    topicToDelete.Username = topic.Username;
                    topicToDelete.CategoryName = CategoryName;
                }
            }
            return View(topicToDelete);

            //Topic topicToDelete = new();
            //foreach (Topic topic in apiTopicController.GetTopic().Value)
            //{
            //    if (topic.CategoryName.Equals(CategoryName))
            //    {
            //        topicToDelete.Username = topic.Username;
            //        topicToDelete.CategoryName = CategoryName;
            //    }
            //}
            //return View(topicToDelete);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Route("topic/Delete/{CategoryName}")]
        public ActionResult Delete(TopicClient topic/*Topic topic*/)
        {
            try
            {
                _restClient.DeleteTopic(topic);
                return RedirectToAction(nameof(Topics));
            }

            catch
            {
                return View();
            }

            //try
            //{
            //    apiTopicController.DeleteTopic(topic);
            //    return RedirectToAction(nameof(Topics));
            //}

            //catch
            //{
            //    return View();
            //}

        }

    }
}