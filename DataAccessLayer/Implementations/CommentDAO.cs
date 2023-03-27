using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DBConnectionNameSpace;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;
using System.Data.Common;
using System.Transactions;
using IsolationLevel = System.Data.IsolationLevel;

namespace DataAccessLayer.Implementations
{
    public class CommentDAO : ICommentDataAccess
    {
        private static int s_waitTime2 = 21;
        private DBConnection _conn;

        public CommentDAO()
        {
            _conn = DBConnection.GetInstance();
        }

         
        private bool UpdatePersonAndPostWithPoints(Person person, Post post, SqlConnection conn, SqlTransaction transaction)
        {

            PostDAO postDAO = new PostDAO();
            bool test2 = postDAO.UpdatePostWithPoints(post, conn, transaction);

            PersonDAO personDAO = new PersonDAO();
            bool test1 = personDAO.UpdatePersonWithPoints(person, conn, transaction);

            bool succes = false;

            if (test1 && test2)
            {
                succes = true;
            }

            return succes;
        }
        public int AddComment(Comment comment)
        {
            SqlConnection conn = new SqlConnection(_conn.DBConnectionString.ConnectionString);
            conn.Open();
            var transaction = conn.BeginTransaction(IsolationLevel.RepeatableRead);
            int i = 0;

            try
            {
                PersonDAO personDAO = new PersonDAO();
                Person person = personDAO.GetPersonWithTransaction(comment.Username, transaction, conn);

                if (person.Usertype.Equals("Moderator"))
                {
                    PostDAO postDAO = new PostDAO();
                    Post post = postDAO.GetPostWithTransaction(comment.PostUsername, comment.PostDateTime,transaction,conn);
                    int waitTime = s_waitTime2;
                    s_waitTime2 -= 7;
                    Thread.Sleep(waitTime * 1000);

                    UpdatePersonAndPostWithPoints(person, post, conn, transaction);
                }


                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;
                    cmd.CommandText = "insert into comment values (@Datetimecomment , " +
                        "@FK_Person_Username, " +
                        "@TextComment, @FK_Post_DateTimePost, " +
                        "@FK_Post_FK_Person_Username)";
                    cmd.Parameters.AddWithValue("Datetimecomment", comment.DateTime);
                    cmd.Parameters.AddWithValue("FK_Person_Username", comment.Username);
                    cmd.Parameters.AddWithValue("TextComment", comment.Text);
                    cmd.Parameters.AddWithValue("FK_Post_DateTimePost", comment.PostDateTime);
                    cmd.Parameters.AddWithValue("FK_Post_FK_Person_Username", comment.PostUsername);
                    cmd.Connection = conn;


                    i = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }

            }
            conn.Close();
            return i;
        }


        public bool DeleteComment(Comment comment)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(_conn.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from comment where Datetimecomment = @Datetimecomment and FK_Person_Username = @FK_Person_Username";
            cmd.Parameters.AddWithValue("Datetimecomment", comment.DateTime);
            cmd.Parameters.AddWithValue("FK_Person_Username", comment.Username);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                success = true;
            }
            conn.Close();

            return success;
        }

        public IEnumerable<Comment> GetAll(DateTime postedAt, String username)
        {
            List<Comment> comments = new List<Comment>();
            SqlConnection conn = new SqlConnection(_conn.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from comment where FK_Post_DateTimePost = @PostedAt And " +
            "FK_Post_FK_Person_Username = @Username";
            cmd.Parameters.AddWithValue("PostedAt", postedAt);
            cmd.Parameters.AddWithValue("Username", username);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Comment comment = new Comment();
                comment.DateTime = reader.GetDateTime(0);
                comment.Username = reader.GetString(1);
                comment.Text = reader.GetString(2);
                comment.PostDateTime = reader.GetDateTime(3);
                comment.PostUsername = reader.GetString(4);
                comments.Add(comment);
            }
            conn.Close();

            return comments;
        }

        public Comment GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Comment GetCommentByPartOfName(string partOfCommentName)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// NEEDS a valid foreign key in post datetime + person in post
        /// </summary>
        /// <param name="Comment"></param>
        /// <returns></returns>
        public bool UpdateComment(Comment comment)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(_conn.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText =
                "update comment set " +
                "textcomment = @textcomment , " +
                "FK_Post_DateTimePost = @FK_Post_DateTimePost , " +
                "FK_Post_FK_Person_Username = @FK_Post_FK_Person_Username  " +
                "where Datetimecomment = @Datetimecomment and FK_Person_Username = @FK_Person_Username ";
            cmd.Parameters.AddWithValue("textcomment", comment.Text);
            cmd.Parameters.AddWithValue("FK_Post_DateTimePost", comment.PostDateTime);
            cmd.Parameters.AddWithValue("FK_Post_FK_Person_Username", comment.PostUsername);
            cmd.Parameters.AddWithValue("Datetimecomment", comment.DateTime);
            cmd.Parameters.AddWithValue("FK_Person_Username", comment.Username);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                success = true;
            }
            conn.Close();

            return success;
        }
    }
}
