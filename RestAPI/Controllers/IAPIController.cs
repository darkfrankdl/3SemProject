using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    public interface IAPIController
    {

        ActionResult AddTopic(Topic topic);
        ActionResult<IEnumerable<Topic>> GetTopic();
        public ActionResult UpdateTopic(Topic topic);
        public ActionResult DeleteTopic(Topic topic);

    }
}