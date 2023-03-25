using DataAccessLayer.Implementations;
using DataAccessLayer.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RestAPI.Controllers.Tests
{
    [TestClass()]
    public class APIPostControllerTests
    {

        [TestMethod()]
        public void AddPostTest()
        {
            //Arrange
            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person person = new Person() { Username = "Dr. Manhattan", Usertype = usertype.Type, 
            Password = "Password1!", Points = 1};
            PersonDAO personDAO = new PersonDAO();
            personDAO.InsertPerson(person);
            APIProfileController apiProfileController = new APIProfileController(personDAO);

            Topic topic = new Topic() { CategoryName = "Concurrency issues", Username = "Dr. Manhattan" };
            TopicDAO topicDAO = new TopicDAO();
            topicDAO.Insert(topic);
            APITopicController apiTopicController = new APITopicController(topicDAO);   




            PostDAO postDAO = new PostDAO();
            APIPostController apiPostController = new(postDAO);
            
            Post post = new()
            {
                TimeOfPost = new DateTime(2019, 11, 17),
                Username = "Dr. Manhattan",
                Text = "Eksempel på tekst",
                Title = "Eksempel på titel", 
                TopicCategoryName = "Concurrency issues",
                Points = 1
              
            };

            //Act
            apiPostController.AddPost(post);

            List<Post> listOfPosts = apiPostController.GetAll().Value.ToList();

            Post postExpectedToBeTrue = null;

            foreach (Post t in listOfPosts)
            {
                if (t.TimeOfPost == post.TimeOfPost && t.Username.Equals("Dr. Manhattan"))
                {
                    postExpectedToBeTrue = new()
                    {
                        TimeOfPost = t.TimeOfPost,
                        Username = t.Username

                    };
                }
            }

            //Assert
            Assert.AreEqual(post.Username, postExpectedToBeTrue.Username);
            Assert.AreEqual(post.TimeOfPost, postExpectedToBeTrue.TimeOfPost);

            //Cleanup
            apiPostController.DeletePost(post.TimeOfPost.ToString("yyyy-MM-dd HH:mm:ss"),post.Username);
            apiTopicController.DeleteTopic(topic.CategoryName);
            apiProfileController.Delete(person.Username);
            usertypeDAO.Delete(usertype);
           
            


        }
        
        [TestMethod()]
        public void ReadPostTest()
        {

            //Arrange
            PostDAO postDAO = new PostDAO();
            APIPostController apiPostController = new(postDAO);

            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person person = new Person()
            {
                Username = "Dr. Manhattan",
                Usertype = usertype.Type,
                Password = "Password1!",
                Points = 1
            };
            PersonDAO personDAO = new PersonDAO();
            personDAO.InsertPerson(person);
            APIProfileController apiProfileController = new APIProfileController(personDAO);

            Topic topic = new Topic() { CategoryName = "Concurrency issues", Username = "Dr. Manhattan" };
            TopicDAO topicDAO = new TopicDAO();
            topicDAO.Insert(topic);
            APITopicController apiTopicController = new APITopicController(topicDAO);

            //Act
            Post postForInsert = new()
            {
                TimeOfPost = new DateTime(2019, 11, 17),
                Username = "Dr. Manhattan",
                Text = "Text test",
                Title = "Title test",
                TopicCategoryName = "Concurrency issues",
                Points = 1

            };

            apiPostController.AddPost(postForInsert);

            List<Post> listOfPosts = apiPostController.GetAll().Value.ToList();

            Post postFromList = null;

            foreach (Post postInList in listOfPosts)
            {
                if (postInList.TimeOfPost == postForInsert.TimeOfPost && postInList.Username == postForInsert.Username)
                {
                    postFromList = new()
                    {
                        TimeOfPost = postInList.TimeOfPost,
                        Username = postInList.Username,
                        Text = postInList.Text,
                        Title = postInList.Title,
                        TopicCategoryName = postInList.TopicCategoryName
                    };
                }
            }



            //Assert
            Assert.AreEqual(postForInsert.Username, postFromList.Username);
            Assert.AreEqual(postForInsert.TimeOfPost, postFromList.TimeOfPost);

            //Cleanup
            apiPostController.DeletePost(postForInsert.TimeOfPost.ToString("yyyy-MM-dd HH:mm:ss"),postForInsert.Username);
            apiTopicController.DeleteTopic(topic.CategoryName);
            apiProfileController.Delete(person.Username);
            usertypeDAO.Delete(usertype);

        }
        
        [TestMethod()]
        public void UpdatePostTest()
        {
            //Arrange
            PostDAO postDAO = new PostDAO();
            APIPostController apiPostController = new(postDAO);

            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person person = new Person()
            {
                Username = "Dr. Manhattan",
                Usertype = usertype.Type,
                Password = "Password1!",
                Points = 1
            };
            PersonDAO personDAO = new PersonDAO();
            personDAO.InsertPerson(person);
            APIProfileController apiProfileController = new APIProfileController(personDAO);

            Topic topic = new Topic() { CategoryName = "Concurrency issues", Username = "Dr. Manhattan" };
            TopicDAO topicDAO = new TopicDAO();
            topicDAO.Insert(topic);
            APITopicController apiTopicController = new APITopicController(topicDAO);

            Post postForAdd = new()
            {
                TimeOfPost = new DateTime(2008, 11, 17),
                Username = "Dr. Manhattan",
                TopicCategoryName = "Concurrency issues",
                Title = "Dr. Manhattans Diary",
                Text = "Text Example",
                Points = 1
            };

            Post postForUpdate = new()
            {
                TimeOfPost = new DateTime(2008, 11, 17),
                Username = "Dr. Manhattan",
                TopicCategoryName = "Concurrency issues",
                Title = "Dr. Manhattans Diary",
                Text = "Today i was walking in the park, everyone was staring",
                Points = 1
            };


            //Act
            apiPostController.AddPost(postForAdd);
            apiPostController.UpdatePost(postForUpdate);

            List<Post> listOfPosts = apiPostController.GetAll().Value.ToList();
            
            Post postFromList = null;
            foreach (Post postInList in listOfPosts)
            {
                if (postInList.TimeOfPost.Equals(postForAdd.TimeOfPost) && postInList.Username.Equals(postForAdd.Username))
                {
                    postFromList = new()
                    {
                        TimeOfPost = postInList.TimeOfPost,
                        Username = postInList.Username,
                       Text = postInList.Text,
                       Title = postInList.Title,
                       TopicCategoryName = postInList.TopicCategoryName

                   };
                }
            }

            //Assert
            Assert.AreEqual(postForUpdate.Text, postFromList.Text);

            //Cleanup
            apiPostController.DeletePost(postFromList.TimeOfPost.ToString("yyyy-MM-dd HH:mm:ss"),postFromList.Username);
            apiTopicController.DeleteTopic(topic.CategoryName);
            apiProfileController.Delete(person.Username);
            usertypeDAO.Delete(usertype);
        }

        
        [TestMethod()]
        public void DeletePostTest()
        {
            //Arrange
            PostDAO postDAO = new();
            APIPostController apiPostController = new(postDAO);

            Usertype usertype = new Usertype() { Type = "Owner" };
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            usertypeDAO.Insert(usertype);

            Person person = new Person()
            {
                Username = "Dr. Manhattan",
                Usertype = usertype.Type,
                Password = "Password1!",
                Points = 1
            };
            PersonDAO personDAO = new PersonDAO();
            personDAO.InsertPerson(person);
            APIProfileController apiProfileController = new APIProfileController(personDAO);

            Topic topic = new Topic() { CategoryName = "Concurrency issues", Username = "Dr. Manhattan" };
            TopicDAO topicDAO = new TopicDAO();
            topicDAO.Insert(topic);
            APITopicController apiTopicController = new APITopicController(topicDAO);


            Post post = new()
            {
                TimeOfPost = new DateTime(2019, 12, 17),
                Username = "Dr. Manhattan",
                Text = "Halli halløj en mand uden tøj",
                Title = "Dr. Manhattans Diary",
                TopicCategoryName = "Concurrency issues",
                Points = 1

            };

            //Act
            apiPostController.AddPost(post);
            apiPostController.DeletePost(post.TimeOfPost.ToString("yyyy-MM-dd HH:mm:ss"), post.Username);

            List<Post> listOfPostsForDelete = apiPostController.GetAll().Value.ToList();

            Post postFromList = null;

            foreach (Post postInList in listOfPostsForDelete)
            {
                if (postInList.Username.Equals(post.Username) && postInList.Text.Equals(post.Text));
                {
                    postFromList = new()
                    {
                        TimeOfPost = postInList.TimeOfPost,
                        Username =postInList.Username,
                        Text = postInList.Text,
                    
                    };

                    postFromList = post;
                }
            }

            //Assert
            Assert.AreEqual(null, postFromList);

            //Cleanup
            apiTopicController.DeleteTopic(topic.CategoryName);
            apiProfileController.Delete(person.Username);
            usertypeDAO.Delete(usertype);

        }
        
    }
}