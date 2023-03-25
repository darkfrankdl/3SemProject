using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Xml.Linq;

namespace DataAccessLayer.Implementations.Tests
{
    [TestClass()]
    public class TopicDAOTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            //Arange
            TopicDAO topicDAO = new TopicDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "UsernameTest";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Topic topic = new Topic();
            topic.CategoryName = "Test";
            topic.Username = person.Username;
            topic.NewCategoryname = "NewCategoryName";

            //Act
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            bool x = topicDAO.Insert(topic);


            //Assert
            Assert.IsTrue(x);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void DeleteCommentTest()
        {
            // arrange

            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            TopicDAO topicDAO = new TopicDAO();

            // adding comments to db

            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "UsernameTest";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Topic topic = new Topic();
            topic.CategoryName = "Test";
            topic.Username = person.Username;
            topic.NewCategoryname = "NewCategoryName";

            // act
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            topicDAO.Delete(topic);

            List<Topic> topics = topicDAO.GetAll().ToList();
            bool success = true;

            for(int i = 0; i < topics.Count; i++)
            {
                if (topics[i].CategoryName.Equals(topic.CategoryName))
                {
                    success = false;
                }
            }


            //Assert

            Assert.IsTrue(success);

            // clean up
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            // arrange
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            TopicDAO topicDAO = new TopicDAO();

            // adding comments to db

            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "UsernameTest";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Topic topic = new Topic();
            topic.CategoryName = "Test";
            topic.Username = person.Username;
            topic.NewCategoryname = "NewCategoryName";

            Topic topic2 = new Topic();
            topic2.CategoryName = "Test2";
            topic2.Username = person.Username;
            topic2.NewCategoryname = "NewCategoryName2";

            // act

            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            topicDAO.Insert(topic2);

            List<Topic> topics = topicDAO.GetAll().ToList();
            int counter = 0;
            foreach (Topic topicInList in topics)
            {
                if (topic.CategoryName.Equals(topicInList.CategoryName))
                {
                    counter = counter + 1;
                }
                else if (topic2.CategoryName.Equals(topicInList.CategoryName))
                {
                    counter = counter + 1;
                }
            }

            // assert 

            Assert.IsTrue(counter == 2);

            // cleanup 
            topicDAO.Delete(topic);
            topicDAO.Delete(topic2);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void UpdateCommentTest()
        {
            // arrange
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            TopicDAO topicDAO = new TopicDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "TESTUSERTYPE";

            Person person = new Person();
            person.Username = "UsernameTest";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Topic topic = new Topic();
            topic.CategoryName = "Test";
            topic.Username = person.Username;
            topic.NewCategoryname = "NewCategoryName";



            Topic topicUpdated = new Topic();
            topicUpdated.CategoryName = "Test";
            topicUpdated.Username = person.Username;
            topicUpdated.NewCategoryname = "Updated";

            // act

            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            topicDAO.Update(topicUpdated);

            bool success = false;
            List<Topic> list = topicDAO.GetAll().ToList();
            foreach (Topic topicInList in list)
            {
                if (topicInList.CategoryName.Equals(topicUpdated.NewCategoryname))
                {
                    success = true;
                }
            }
            // Assert

            Assert.IsTrue(success);

            // clean up
            topicDAO.Delete(list[0]);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }
    }
}