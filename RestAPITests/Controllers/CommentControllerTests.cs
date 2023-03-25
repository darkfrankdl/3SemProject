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
    public class CommentControllerTests
    {

        [TestMethod()]
        public void AddCommentTest()
        {
            // Arrange
            // creating the objects necessary for the test

            // DAOs
            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
            TopicDAO topicDAO = new TopicDAO();

            //API Controller
            IAPICommentController controller = new APICommentController(commentDAO);
            
            // individual model objects
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 5;
            // this is the comment to be added
            Comment comment = new Comment();
            comment.DateTime = new DateTime(2010, 10, 11);
            comment.Username = person.Username;
            comment.Text = "myText";
            comment.PostDateTime = post.TimeOfPost;
            comment.PostUsername = post.Username;
           
            
            // act

            // inserting the necessary thing in the DB, for inserting a comment
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);
            controller.AddComment(comment);

            // getting the comment in the DB in a list
            List<Comment> comments = commentDAO.GetAll(comment.PostDateTime,comment.PostUsername).ToList();
            // the variable below "success" used for the Assert
            bool success = false;

            if (comments.Count == 1)
            {
                success = true;
            }
            //Assert
            Assert.IsTrue(success);

            // clean up
            commentDAO.DeleteComment(comment);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        //GETALL
        [TestMethod()]
        public void CommentsTest()
        {
            // Arrange
            // creating the objects necessary for the test

            // DAOs
            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
            TopicDAO topicDAO = new TopicDAO();

            //API Controller
            IAPICommentController controller = new APICommentController(commentDAO);

            // individual model objects
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 1;
            // this is the comments to be added
            Comment comment = new Comment();
            comment.DateTime = new DateTime(2010, 10, 11);
            comment.Username = person.Username;
            comment.Text = "myText";
            comment.PostDateTime = post.TimeOfPost;
            comment.PostUsername = post.Username;

            Comment comment2 = new Comment();
            comment2.DateTime = new DateTime(2010, 10, 12);
            comment2.Username = person.Username;
            comment2.Text = "myText2";
            comment2.PostDateTime = post.TimeOfPost;
            comment2.PostUsername = post.Username;

            // act

            // inserting the necessary thing in the DB, for inserting a comment
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);
            commentDAO.AddComment(comment);
            commentDAO.AddComment(comment2);
            List<Comment> comments = controller.Comments(post.TimeOfPost,post.Username).Value.ToList();

            // the variable below "success" used for the Assert
            int counter = 0;
            foreach(Comment commentLoop in comments)
            {
                if (commentLoop.Text.Equals(comment.Text) || commentLoop.Text.Equals(comment2.Text))
                {
                    ++counter;
                }
            }

            //Assert
            Assert.IsTrue(counter == 2);

            // clean up
            commentDAO.DeleteComment(comment);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void DeleteCommentTest()
        {
            // Arrange
            // creating the objects necessary for the test

            // DAOs
            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
            TopicDAO topicDAO = new TopicDAO();

            //API Controller
            IAPICommentController controller = new APICommentController(commentDAO);

            // individual model objects
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 1;
            // this is the comments to be added
            Comment comment = new Comment();
            comment.DateTime = new DateTime(2010, 10, 11);
            comment.Username = person.Username;
            comment.Text = "myText";
            comment.PostDateTime = post.TimeOfPost;
            comment.PostUsername = post.Username;

            // act

            // inserting the necessary thing in the DB, for inserting a comment
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);
            commentDAO.AddComment(comment);
            controller.DeleteComment(comment.DateTime,comment.Username);
            List<Comment> comments = controller.Comments(post.TimeOfPost,post.Username).Value.ToList();

            // the variable below "success" used for the Assert
            int counter = 0;
            for(int i = 0; i<comments.Count;i++)
            {
                if (comments[i].Text.Equals(comment.Text))
                {
                    ++counter;
                }
            }
            //Assert
            Assert.IsTrue(counter == 0);

            // clean up
            commentDAO.DeleteComment(comment);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void UpdateCommentTest()
        {
            // Arrange
            // creating the objects necessary for the test

            // DAOs
            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
            TopicDAO topicDAO = new TopicDAO();

            //API Controller
            IAPICommentController controller = new APICommentController(commentDAO);

            // individual model objects
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 1;
            // this is the comments to be added
            Comment comment = new Comment();
            comment.DateTime = new DateTime(2010, 10, 11);
            comment.Username = person.Username;
            comment.Text = "myText";
            comment.PostDateTime = post.TimeOfPost;
            comment.PostUsername = post.Username;

            Comment commentUpdated = new Comment();
            commentUpdated.DateTime = new DateTime(2010, 10, 11);
            commentUpdated.Username = person.Username;
            commentUpdated.Text = "Update";
            commentUpdated.PostDateTime = post.TimeOfPost;
            commentUpdated.PostUsername = post.Username;

            // act

            // inserting the necessary thing in the DB, for inserting a comment
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);
            commentDAO.AddComment(comment);
            commentDAO.UpdateComment(commentUpdated);
            List<Comment> comments = controller.Comments(post.TimeOfPost,post.Username).Value.ToList();

            // the variable below "success" used for the Assert
            bool success = false;
            if (comments[0].Text.Equals(commentUpdated.Text))
            {
                success = true;
            }
            //Assert
            Assert.IsTrue(success);

            // clean up
            commentDAO.DeleteComment(comment);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }
    }
}