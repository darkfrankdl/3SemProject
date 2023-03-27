using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataAccessLayer.DBConnectionNameSpace;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.VisualBasic;

namespace DataAccessLayer.Implementations
{
    public class PostDAO : IPostDataAccess
    {
        private DBConnection? _dbConnection;
        SqlConnectionStringBuilder _connectionStringBuilder;

        public PostDAO()
        {
            _dbConnection = DBConnection.GetInstance();

        }
        public IEnumerable<Post> GetAll()
        {
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Post";

            SqlDataReader reader = cmd.ExecuteReader();


            List<Post> list = new List<Post>();

            while (reader.Read())

            {
                Post Post = new()
                {
                    TimeOfPost = reader.GetDateTime(0),
                    Username = reader.GetString(1),
                    Text = reader.GetString(2),
                    Title = reader.GetString(3),
                    TopicCategoryName = reader.GetString(4),
                    Points = reader.GetInt32(5)
                };

                list.Add(Post);

            }


            // 5. Clean up
            conn.Close();

            return list;
        }
        public Post GetPost(string? postUsername, string postDateTime)
        {
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Post Where FK_Person_Username = @username And " +
                "DateTimePost = @dateTimePost";
            cmd.Parameters.AddWithValue("username", postUsername);
            cmd.Parameters.AddWithValue("dateTimePost", postDateTime);


            SqlDataReader reader = cmd.ExecuteReader();

            Post post = new();
            while (reader.Read())
            {
                post.TimeOfPost = reader.GetDateTime(0);
                post.Username = reader.GetString(1);
                post.Text = reader.GetString(2);
                post.Title = reader.GetString(3);
                post.TopicCategoryName = reader.GetString(4);
                post.Points = reader.GetInt32(5);
            }
            reader.Close();
            conn.Close();
            return post;
        }

        public Post GetPostWithTransaction(string? postUsername, DateTime? postDateTime, SqlTransaction transaction, SqlConnection conn)
        {

            SqlCommand cmd = conn.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = "SELECT * FROM Post Where FK_Person_username = @Username And " +
                "dateTimePost = @DateTimePost";
            cmd.Parameters.AddWithValue("username", postUsername);
            cmd.Parameters.AddWithValue("dateTimePost", postDateTime);


            SqlDataReader reader = cmd.ExecuteReader();

            Post post = new();
            while (reader.Read())
            {
                post.TimeOfPost = reader.GetDateTime(0);
                post.Username = reader.GetString(1);
                post.Text = reader.GetString(2);
                post.Title = reader.GetString(3);
                post.TopicCategoryName = reader.GetString(4);
                post.Points = reader.GetInt32(5);
            }
            reader.Close();
            return post;
        }




        public bool Insert(Post post)
        {
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Post VALUES (@DateTimePost, @FK_Person_Username, @TextPost, @Title, @FK_Topic_CategoryName, @Point )";
            cmd.Parameters.AddWithValue("DateTimePost", post.TimeOfPost);
            cmd.Parameters.AddWithValue("FK_Person_Username", post.Username);
            cmd.Parameters.AddWithValue("TextPost", post.Text);
            cmd.Parameters.AddWithValue("Title", post.Title);
            cmd.Parameters.AddWithValue("FK_Topic_CategoryName", post.TopicCategoryName);
            cmd.Parameters.AddWithValue("Point", post.Points);


            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected == 1;
        }

        public bool Update(Post post)
        {
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Post SET " +
                "TextPost = @Text, " +
                "FK_Topic_Categoryname = @TopicCategoryName, " +
                "Point = @Point " +
                "WHERE DateTimePost = @Datetime AND FK_Person_Username = @Username";
            cmd.Parameters.AddWithValue("DateTime", post.TimeOfPost);
            cmd.Parameters.AddWithValue("Username", post.Username);
            cmd.Parameters.AddWithValue("Text", post.Text);
            cmd.Parameters.AddWithValue("TopicCategoryName", post.TopicCategoryName);
            cmd.Parameters.AddWithValue("Point", post.Points);


            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected == 1;
        }

        public bool UpdatePostWithPoints(Post post, SqlConnection conn, SqlTransaction transaction)
        {
            int rowsAffected = 0;


                SqlCommand cmd = conn.CreateCommand();
                cmd.Transaction = transaction;
                cmd.CommandText = "UPDATE Post SET " +
                    "point = @Point " +
                    "WHERE FK_Person_username = @Username AND " +
                    " dateTimePost = @DateTimePost "; // can add the follwing to query ->> and point > 0
            cmd.Parameters.AddWithValue("username", post.Username);
                cmd.Parameters.AddWithValue("dateTimePost", post.TimeOfPost);
                cmd.Parameters.AddWithValue("point", --post.Points);
                rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected == 1;
        }

        public bool Delete(Post post)
        {
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Post WHERE DateTimePost = @DateTimePost AND FK_Person_Username = @UserName";
            cmd.Parameters.AddWithValue("DateTimePost", post.TimeOfPost);
            cmd.Parameters.AddWithValue("UserName", post.Username);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected == 1;
        }

        public IEnumerable<Post> GetPostsFromTopicWithID(String? categoryName)
        {

            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Post Where FK_Topic_Categoryname = @TopicCategoryname";
            cmd.Parameters.AddWithValue("TopicCategoryname", categoryName);
            


            SqlDataReader reader = cmd.ExecuteReader();

            List<Post> listOfPosts = new List<Post>();

            while (reader.Read())

            {
                Post Post = new()
                {
                    TimeOfPost = reader.GetDateTime(0),
                    Username = reader.GetString(1),
                    Text = reader.GetString(2),
                    Title = reader.GetString(3),
                    TopicCategoryName = reader.GetString(4),
                    Points = reader.GetInt32(5)
                };

                listOfPosts.Add(Post);
            }
            // 5. Clean up
            conn.Close();

            return listOfPosts;
        }

    }
}
