using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.DBConnectionNameSpace;
namespace DataAccessLayer.Implementations
{
    public class TopicDAO : ITopicDataAccess
    {
        private DBConnection _dbConnection;

        public TopicDAO()
        {
            _dbConnection = DBConnection.GetInstance();

        }

         public IEnumerable<Topic> GetAll()
        {
            SqlConnection sqlConnection = new(_dbConnection.DBConnectionString.ConnectionString);
            sqlConnection.Open();

          
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Topic";

            SqlDataReader reader = cmd.ExecuteReader();

            
            List<Topic> list = new List<Topic>();

            while (reader.Read())

            { 
                Topic topic = new() {
                CategoryName = reader.GetString(0),
                Username = reader.GetString(1)
                };

                list.Add(topic);
                
            }
            

            // 5. Clean up
            sqlConnection.Close();

            return list;
        }

        public Topic Get(Topic topic)
        {
            SqlConnection sqlConnection = new(_dbConnection.DBConnectionString.ConnectionString);
            sqlConnection.Open();


            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Topic where Categoryname = @CategoryName";
            cmd.Parameters.AddWithValue("Categoryname", topic.CategoryName);


            SqlDataReader reader = cmd.ExecuteReader();

            Topic topicRead = null;

            while (reader.Read())

            {
                topicRead = new()
                {
                    CategoryName = reader.GetString(0),
                    Username = reader.GetString(1)
                };

            }


            // 5. Clean up
            sqlConnection.Close();

            return topicRead;
        }


        public bool Insert(Topic topic)
        {

            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Topic VALUES (@CategoryName, @FK_Person_Username)";
            cmd.Parameters.AddWithValue("Categoryname", topic.CategoryName);
            cmd.Parameters.AddWithValue("FK_Person_Username", topic.Username);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected == 1;
        }

        public bool Update(Topic topic)
        {


            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Topic SET " +
                "Categoryname = @NewCategoryname, " +
                "FK_Person_Username = @username " +
                "WHERE Categoryname = @categoryname";
            cmd.Parameters.AddWithValue("categoryname", topic.CategoryName);
            cmd.Parameters.AddWithValue("newcategoryname", topic.NewCategoryname);
            cmd.Parameters.AddWithValue("username", topic.Username);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected == 1;
        }
        
        public bool Delete(Topic topic)
        {

            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Topic WHERE Categoryname = @categoryname";
            cmd.Parameters.AddWithValue("categoryname", topic.CategoryName);
           

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected == 1;
        }
        
    }
}
