using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Controllers;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Implementations;

namespace Webserver__MVC_.Controllers
{
    public class ForumController : Controller
    {
        //GET: ForumController
        public ActionResult Forum()
        {
            return View();
        }
    }
}


