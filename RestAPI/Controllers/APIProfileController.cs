using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class APIProfileController : ControllerBase
    {
        private IPersonDataAccess _dataAccess;
        public APIProfileController(IPersonDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            List<Person> listToReturn = _dataAccess.GetAll().ToList();

            if(listToReturn != null)
            {
                return listToReturn; 
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpPost("{Username}")]
        public ActionResult Create(Person person)
        {
            return Ok(_dataAccess.InsertPerson(person));           

        }

        [HttpPut("{Username}")]
        public ActionResult Edit(Person person)
        {
            return Ok(_dataAccess.UpdatePerson(person));
        }

        [HttpDelete("{username}")]
        public ActionResult Delete(string username)
        {
            Person person = new Person () { Username = username };
            return (Ok(_dataAccess.Delete(person)));
        }
    }
}
