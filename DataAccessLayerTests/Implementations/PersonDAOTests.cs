using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.ComponentModel;

namespace DataAccessLayer.Implementations.Tests
{
    [TestClass()]
    public class PersonDAOTests
    {
        [TestMethod()]
        public void InsertPersonTest()
        {
            //Arange
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            // adding comments to db

            Usertype usertype = new Usertype();
            usertype.Type = "Test";

                Person p = new();
                {
                p.Username = "UsernameTest";
                p.Password = "123";
                p.Points = 2;
                p.Usertype = usertype.Type;
                };

                //Act
                usertypeDAO.Insert(usertype);
                bool o = personDAO.InsertPerson(p);

                //Assert
                Assert.IsTrue(o);
                personDAO.Delete(p);
            usertypeDAO.Delete(usertype);

        }

        [TestMethod()]
        public void GetAllTest()
        {
            // arrange
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "UsernameTest";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            // act

            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);


            bool success = false;
            foreach (Person personInList in personDAO.GetAll())
            {
                if (personInList.Username.Equals(person.Username))
                {
                    success = true;
                }
            }
            // Assert

            Assert.IsTrue(success);

            // clean up
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void UpdatePersonTest()
        {
            // arrange
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "UsernameTest";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;


            Person personUpdate = new Person();
            personUpdate.Username = "UsernameTest";
            personUpdate.Usertype = usertype.Type;
            personUpdate.Password = "7777";
            personUpdate.Points = 15;
            // act

            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);

            personDAO.UpdatePerson(personUpdate);
            bool success = false;
            foreach (Person personInList in personDAO.GetAll())
            {
                if (personInList.Username.Equals(personUpdate.Username))
                {
                    success = true;
                }
            }
            // Assert

            Assert.IsTrue(success);

            // clean up
            personDAO.Delete(personUpdate);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            // arrange
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "UsernameTest";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            // act

            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);

            personDAO.Delete(person);
            bool success = true;
            foreach (Person personInList in personDAO.GetAll())
            {
                if (personInList.Username.Equals(person.Username))
                {
                    success = false;
                }
            }
            // Assert

            Assert.IsTrue(success);

            // clean up
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }
    }
}