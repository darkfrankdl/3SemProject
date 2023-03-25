using DataAccessLayer.Implementations;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RestAPI.Controllers.Tests
{
    [TestClass()]
    public class APIControllerTests
    {

        [TestMethod()]
        public void AddTopicTest()
        {
            //Arrange
            TopicDAO topicDAO = new TopicDAO();
            APITopicController apiController = new(topicDAO);
            PersonDAO personDAO = new PersonDAO();
            APIProfileController apiProfileController = new(personDAO);
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "WeebSlave";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Topic topic = new()
            {
                CategoryName = "Waifus", Username = person.Username
            };

            //Act
            usertypeDAO.Insert(usertype);
            apiProfileController.Create(person);
            apiController.AddTopic(topic);
           
            List<Topic> listOfTopics = apiController.GetTopic().Value.ToList();

            Topic topic1 = null;

            foreach (Topic t in listOfTopics)
            {
                if (t.CategoryName.Equals(topic.CategoryName)) {
                    topic1 = new()
                    {
                        CategoryName = topic.CategoryName
                    };
                }
            }

            //Assert
            Assert.AreEqual(topic.CategoryName, topic1.CategoryName);

            //Cleanup
            apiController.DeleteTopic(topic.CategoryName);
            apiProfileController.Delete(person.Username);
            usertypeDAO.Delete(usertype);


        }

        [TestMethod()]
        public void ReadTopicTest()
        {

            //Arrange
            TopicDAO topicDAO = new TopicDAO();
            APITopicController apiController = new(topicDAO);
            PersonDAO personDAO = new PersonDAO();
            APIProfileController apiProfileController = new(personDAO);
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "WeebSlave";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Topic topic = new()
            {
                CategoryName = "Waifus",
                Username = person.Username
            };

            usertypeDAO.Insert(usertype);
            apiProfileController.Create(person);
            apiController.AddTopic(topic);

            List<Topic> listOfTopics = apiController.GetTopic().Value.ToList();

            Topic topicForAssert = null;

            foreach (Topic topicInList in listOfTopics)
            {
                if (topicInList.CategoryName.Equals(topic.CategoryName) && topicInList.Username.Equals(topic.Username))
                {
                    topicForAssert = new()
                    {
                        CategoryName = "Waifus"
                    };
                }
            }



            //Assert
            Assert.AreEqual(topic.CategoryName, topicForAssert.CategoryName);

            //Cleanup
            apiController.DeleteTopic(topic.CategoryName);
            apiProfileController.Delete(person.Username);
            usertypeDAO.Delete(usertype);

        }

        [TestMethod()]
        public void UpdateTopicTest()
        {
            //Arrange
            TopicDAO topicDAO = new TopicDAO();
            APITopicController apiController = new(topicDAO);
            PersonDAO personDAO = new PersonDAO();
            APIProfileController apiProfileController = new(personDAO);
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "WeebSlave";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Person person2 = new Person();
            person2.Username = "Update";
            person2.Usertype = usertype.Type;
            person2.Password = "123";
            person2.Points = 5;

            Topic topic = new()
            {
                CategoryName = "Waifus",
                Username = person.Username,
                NewCategoryname = "NewCategoryName"
            };

            Topic topic2 = new()
            {
                CategoryName = topic.CategoryName,
                Username = person2.Username,
                NewCategoryname = "NewCategoryName2"
            };

            usertypeDAO.Insert(usertype);
            apiProfileController.Create(person);
            apiProfileController.Create(person2);
            apiController.AddTopic(topic);
            apiController.UpdateTopic(topic2);


            List<Topic> listOfTopics = apiController.GetTopic().Value.ToList();

            Topic topicForAssert = null;

            foreach (Topic topicInList in listOfTopics)
            {
                if (topicInList.CategoryName.Equals(topic2.NewCategoryname) && topicInList.Username.Equals(topic2.Username))
                {
                    topicForAssert = new()
                    {
                        CategoryName = topicInList.CategoryName
                    };
                }
            }



            //Assert
            Assert.AreEqual(topic2.NewCategoryname, topicForAssert.CategoryName);

            //Cleanup
            apiController.DeleteTopic(topicForAssert.CategoryName);
            apiProfileController.Delete(person.Username);
            apiProfileController.Delete(person2.Username);
            usertypeDAO.Delete(usertype);

        }

        [TestMethod()]
        public void DeleteTopicTest()
        {

            //Arrange
            TopicDAO topicDAO = new TopicDAO();
            APITopicController apiController = new(topicDAO);
            PersonDAO personDAO = new PersonDAO();
            APIProfileController apiProfileController = new(personDAO);
            UsertypeDAO usertypeDAO = new UsertypeDAO();

            // adding comments to db
            Usertype usertype = new Usertype();
            usertype.Type = "Test";

            Person person = new Person();
            person.Username = "WeebSlave";
            person.Usertype = usertype.Type;
            person.Password = "123";
            person.Points = 5;

            Topic topic = new()
            {
                CategoryName = "Waifus",
                Username = "WeebSlave"

            };

            //Act
            usertypeDAO.Insert(usertype);
            apiProfileController.Create(person);
            apiController.AddTopic(topic);
            apiController.DeleteTopic(topic.CategoryName);

            List<Topic> listOfTopicsForDelete = apiController.GetTopic().Value.ToList();

            Topic topic1 = null;

            foreach (Topic topicInList in listOfTopicsForDelete)
            {
                if (topic.Equals(topic.CategoryName))
                {
                    topic1 = new()
                    {
                        CategoryName ="Waifus"
                    };
                }
            }

            //Assert
            Assert.AreEqual(null, topic1);

            apiController.DeleteTopic(topic.CategoryName);
            apiProfileController.Delete(person.Username);
            usertypeDAO.Delete(usertype);
        }     
    }
}