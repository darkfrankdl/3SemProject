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
    public class CommentDAOTests
    {
        [TestMethod()]
        public void AddCommentTest()
        {
            // arrange

            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 1;


            Comment comment1 = new Comment();
            comment1.DateTime = new DateTime(2010, 10, 11);
            comment1.Username = person.Username;
            comment1.Text = "myText";
            comment1.PostDateTime = post.TimeOfPost;
            comment1.PostUsername = post.Username;
            
            // act
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);
            commentDAO.AddComment(comment1);
            List<Comment> comments = commentDAO.GetAll(post.TimeOfPost,post.Username).ToList();
            bool success = false;

            if (comments.Count == 1)
            {
                success = true;
            }
            //Assert
            Assert.IsTrue(success);

            // clean up
            commentDAO.DeleteComment(comment1);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person); 
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void DeleteCommentTest()
        {
            // arrange

            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 1;


            Comment comment1 = new Comment();
            comment1.DateTime = new DateTime(2010, 10, 11);
            comment1.Username = person.Username;
            comment1.Text = "myText";
            comment1.PostDateTime = post.TimeOfPost;
            comment1.PostUsername = post.Username;

            // act
            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);
            commentDAO.DeleteComment(comment1);
            List<Comment> comments = commentDAO.GetAll(post.TimeOfPost, post.Username).ToList();
            bool success = false;
            
            if(comments.Count == 0)
            {
                success = true;
            }

            //Assert

            Assert.IsTrue(success);

            // clean up
            commentDAO.DeleteComment(comment1);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            // arrange
            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 1;

            Comment comment1 = new Comment();
            comment1.DateTime = new DateTime(2010, 10, 11);
            comment1.Username = person.Username;
            comment1.Text = "myText";
            comment1.PostDateTime = post.TimeOfPost;
            comment1.PostUsername = post.Username;

            Comment comment2 = new Comment();
            comment2.DateTime = new DateTime(2010, 10, 12);
            comment2.Username = person.Username;
            comment2.Text = "myText2";
            comment2.PostDateTime = post.TimeOfPost;
            comment2.PostUsername = post.Username;

            // act

            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);

            commentDAO.AddComment(comment1);
            commentDAO.AddComment(comment2);

            
            List <Comment> comments = commentDAO.GetAll(post.TimeOfPost, post.Username).ToList();
            int counter = 0;
            foreach (Comment comment in comments)
            {

                if(comment.Text.Equals( comment1.Text))
                { 
                    counter = counter + 1;
                }
                else if (comment.Text.Equals( comment2.Text))
                {
                    counter = counter + 1;
                }
            }

            // assert 

            Assert.IsTrue(counter == 2);

            // cleanup 
            commentDAO.DeleteComment(comment1);
            commentDAO.DeleteComment(comment2);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }

        [TestMethod()]
        public void UpdateCommentTest()
        {
            // arrange
            CommentDAO commentDAO = new CommentDAO();
            PersonDAO personDAO = new PersonDAO();
            UsertypeDAO usertypeDAO = new UsertypeDAO();
            PostDAO postDAO = new PostDAO();
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

            Post post = new Post();
            post.TimeOfPost = new DateTime(2010, 10, 10);
            post.Username = person.Username;
            post.Text = "post text";
            post.TopicCategoryName = topic.CategoryName;
            post.Title = "my title";
            post.Points = 1;

            Comment comment1 = new Comment();
            comment1.DateTime = new DateTime(2010, 10, 11);
            comment1.Username = person.Username;
            comment1.Text = "myText";
            comment1.PostDateTime = post.TimeOfPost;
            comment1.PostUsername = post.Username;

            Comment updatedComment = new Comment();
            updatedComment.DateTime = new DateTime(2010, 10, 11);
            updatedComment.Username = person.Username;
            updatedComment.Text = "myText2 UPDATED";
            updatedComment.PostDateTime = post.TimeOfPost;
            updatedComment.PostUsername = post.Username;
            // act

            usertypeDAO.Insert(usertype);
            personDAO.InsertPerson(person);
            topicDAO.Insert(topic);
            postDAO.Insert(post);

            commentDAO.AddComment(comment1);

            commentDAO.UpdateComment(updatedComment);
            bool success = false;
            foreach (Comment comment in commentDAO.GetAll(post.TimeOfPost, post.Username))
            {
                if(comment.Text.Equals(updatedComment.Text))
                {
                    success = true;
                }
            }
            // Assert

            Assert.IsTrue(success);

            // clean up
            commentDAO.DeleteComment(comment1);
            postDAO.Delete(post);
            topicDAO.Delete(topic);
            personDAO.Delete(person);
            usertypeDAO.Delete(usertype);
        }
    }
}