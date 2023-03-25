using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Controllers;
using Client.Controllers;
using Client.Models;
using System.Text.Json;

namespace Webserver__MVC_.Controllers
{
    public class ProfileController : Controller
    {
        //private APIProfileController _apiControllerProfile;
        private ClientProfile _client = new ClientProfile("https://localhost:7146/api/APIProfile");

        // GET: ProfileController
        public ActionResult Profiles() 
        {
            List<PersonClient> persons = _client.Profiles().ToList();
            return View(persons);
        }

        // GET: ProfileController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfileController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<PersonClient> Create(PersonClient createdPerson)
        {
            try
            {
                _client.InsertProfile(createdPerson);
                return RedirectToAction(nameof(Profiles));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileController/Edit/5
        public ActionResult Edit(string username)
        {
            // object to use at the end 
            PersonClient p = new PersonClient();
            // getting the object to edit
            foreach (PersonClient person in _client.Profiles())
            {
                if (person.Username.Equals(username))
                {
                    p.Username = person.Username;
                    p.Password = person.Password;
                    p.Usertype = person.Usertype;
                    p.Points = person.Points;
                }
            }
            return View(p);
        }

        // POST: ProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<PersonClient> Edit(PersonClient person)
        {
            try
            {
                _client.UpdateProfile(person);
                return RedirectToAction(nameof(Profiles));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileController/Delete/5

        public ActionResult Delete(string username)
        {
            PersonClient personToDelete = new PersonClient();
            foreach (PersonClient person in _client.Profiles())
            {
                if (person.Username.Equals(username))
                {
                    personToDelete.Username = person.Username;
                    personToDelete.Password = person.Password;
                    personToDelete.Usertype = person.Usertype;
                    personToDelete.Points = person.Points;
                }
            }
            return View(personToDelete);
        }

        // POST: ProfileController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Delete(PersonClient person)
        {
            try
            {
                _client.DeleteProfile(person);
                return RedirectToAction(nameof(Profiles));
            }
            catch
            {
                return View();
            }
        }
    }
}