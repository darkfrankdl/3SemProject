using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace RestAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class APITopicController : ControllerBase
    {
        private ITopicDataAccess _dataAccess;

        public APITopicController(ITopicDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Topic>> GetTopic()
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

        [HttpPost("{CategoryName}")]
        public ActionResult AddTopic(Topic topic)
        {
            return Ok(_dataAccess.Insert(topic));

        }

        [HttpPut("{newCategoryName}")]
        public ActionResult UpdateTopic(Topic topic)
        {
            return Ok(_dataAccess.Update(topic));


        }
        [HttpDelete()]
        [Route ("{categoryName}")]
        public ActionResult DeleteTopic(string categoryName)
        {
            Topic topic = new Topic () { CategoryName = categoryName };
            return (Ok(_dataAccess.Delete(topic)));
        }

    }
}

