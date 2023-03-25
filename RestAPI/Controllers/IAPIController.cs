using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    public interface IAPIController
    {
        //ActionResult<int> AddTopic(Topic topic);

        ActionResult AddTopic(Topic topic);
        ActionResult<IEnumerable<Topic>> GetTopic();
        //ActionResult<bool> UpdateTopic(Topic topic);
        public ActionResult UpdateTopic(Topic topic);
        public ActionResult DeleteTopic(Topic topic);

    }
}