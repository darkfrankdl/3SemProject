using DataAccessLayer.Implementations;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Controllers.Tests
{
    [TestClass()]
    public class APIProfileControllerTests
    {

        [TestMethod()]
        /// test getting the entire list 
        public void GetAllTest()
        {
            // arrange 
            // CREATE OBJECTS TO INSERT INTO DB
            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person person1 = new Person() {Username = "Dr. Manhattan" , Password = "Password1!", Points=20,Usertype = "Owner" };
            Person person2 = new Person() { Username = "John", Password = "123", Points = 0, Usertype = "Owner" };
            Person person3 = new Person() { Username = "WeebSlave", Password = "Password1", Points = 2, Usertype = "Owner" };

            APIProfileController apiProfile = new APIProfileController(new PersonDAO());
 
            apiProfile.Create(person1);
            apiProfile.Create(person2);
            apiProfile.Create(person3);

            // act
            List<Person> persons = apiProfile.GetAll().Value.ToList();
            bool success = false;
            int count = 0;
            for(int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Username.Equals(person1.Username)||persons[i].Username.Equals(person2.Username)|| persons[i].Username.Equals(person3.Username))
                {
                    ++count;
                }
                if(count == 3)
                {
                    success = true;
                }
            }

            // assert
            Assert.IsTrue(success);

            // clean up

            for (int i = 0; i < persons.Count; i++)
            {
                apiProfile.Delete(persons[i].Username);
                
            }
            usertypeDAO.Delete(usertype);

        }

        [TestMethod()]
        public void CreateTest()
        {
            // arrange 
            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person person1 = new Person() { Username = "Test", Password = "Password1!", Points = 20, Usertype = "Owner" };

            APIProfileController apiProfile = new APIProfileController(new PersonDAO());
            // act
            apiProfile.Create(person1);

            List<Person> persons = apiProfile.GetAll().Value.ToList();
            bool success = false;
            foreach (Person person in persons)
            {
                if (person.Username.Equals(person1.Username))
                {
                    success = true;
                }
            }
            // assert
            Assert.IsTrue(success);

            apiProfile.Delete(person1.Username );
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void EditTest()
        {
            // arrange 
            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person CreatePerson = new Person() { Username = "Test", Password = "Password1!", Points = 20, Usertype = "Owner" };

            APIProfileController apiProfile = new APIProfileController(new PersonDAO());
            apiProfile.Create(CreatePerson);
            Person EditedPerson = new Person() { Username = "Test", Password = "Edited", Points = 20, Usertype = "Owner" };
            // act

            apiProfile.Edit(EditedPerson);

            List<Person> persons = apiProfile.GetAll().Value.ToList();
            bool success = false;
            foreach(Person person in persons)
            {
                if(person.Password.Equals(EditedPerson.Password))
                {
                    success = true;
                }
            }
            // assert
            Assert.IsTrue(success);

            apiProfile.Delete(EditedPerson.Username);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            // arrange 
            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person personToDelete = new Person() { Username = "Test", Password = "Password1!", Points = 20, Usertype = "Owner" };

            APIProfileController apiProfile = new APIProfileController(new PersonDAO());
            apiProfile.Create(personToDelete);
            // act

            apiProfile.Delete(personToDelete.Username);

            List<Person> persons = apiProfile.GetAll().Value.ToList();
            bool success = false;
            foreach (Person person in persons)
            {
                if (person.Username.Equals(personToDelete.Username))
                {
                    success = true;
                }
            }
            // assert
            Assert.IsFalse(success);

            usertypeDAO.Delete(usertype);
            apiProfile.Delete(personToDelete.Username);

        }
    }
}