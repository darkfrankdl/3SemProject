using DataAccessLayer.DBConnectionNameSpace;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Data.SqlClient;

namespace DataAccessLayer.Implementations
{
    public class PersonDAO : IPersonDataAccess
    {

        private DBConnection _dbConnection;

        public PersonDAO()
        {
            _dbConnection = DBConnection.GetInstance();
        }

        public IEnumerable<Person> GetAll()
        {

            // 1. Create and open a connection to the database
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();

            // 2. Creates a sql command that will be executed on the database
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Person";

            // 3. Creates a datareader object to retrieve data
            SqlDataReader reader = cmd.ExecuteReader();

            // 4. Passes the data from the reader into a collection of Post objects
            List<Person> list = new List<Person>();

            while (reader.Read())
            {
                Person person = new Person();
                person.Username = reader.GetString(0);
                person.Password = reader.GetString(1);
                person.Points = reader.GetInt32(2);
                person.Usertype = reader.GetString(3);
                list.Add(person);
            }
            // 5. Clean up
            conn.Close();

            return list;
        }

        public bool InsertPerson(Person person)
        {
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Person VALUES (@Username, @User_password, @Points, @Usertype)";
            cmd.Parameters.AddWithValue("Username", person.Username);
            cmd.Parameters.AddWithValue("User_password", person.Password);
            cmd.Parameters.AddWithValue("Points", person.Points);
            cmd.Parameters.AddWithValue("Usertype", person.Usertype);

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected == 1;
        }

        public bool UpdatePerson(Person person)
        {
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Person SET " +
                "User_password = @User_password, " +
                "Points = @Points," +
                "FK_Usertype_Usertype = @Usertype " +
                "WHERE username = @Username";
            cmd.Parameters.AddWithValue("Username", person.Username);
            cmd.Parameters.AddWithValue("User_password", person.Password);
            cmd.Parameters.AddWithValue("Points", person.Points);
            cmd.Parameters.AddWithValue("Usertype", person.Usertype);
            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffected == 1;
        }

        public bool UpdatePersonWithPoints(Person person, SqlConnection conn, SqlTransaction transaction)
        {

            SqlCommand cmd = conn.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = "UPDATE Person SET " +
                "points = @Points " +
                "WHERE username = @Username";
            cmd.Parameters.AddWithValue("username", person.Username);
            cmd.Parameters.AddWithValue("points", ++person.Points);
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }

        public bool Delete(Person person)
        {

            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Person WHERE Username = @Username";
            cmd.Parameters.AddWithValue("Username", person.Username);
            //Add? 
            int rowsAffedted = cmd.ExecuteNonQuery();

            conn.Close();

            return rowsAffedted == 1;
        }

        public Person GetPerson(String? username)
        {
            // 1. Create and open a connection to the database
            SqlConnection conn = new(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();

            // 2. Creates a sql command that will be executed on the database
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Person where Username =  @Username";
            cmd.Parameters.AddWithValue("Username", username);

            // 3. Creates a datareader object to retrieve data
            SqlDataReader reader = cmd.ExecuteReader();

            // 4. Passes the data from the reader into a collection of Post objects
            Person person = new();

            while (reader.Read())
            {
                person.Username = reader.GetString(0);
                person.Password = reader.GetString(1);
                person.Points = reader.GetInt32(2);
                person.Usertype = reader.GetString(3);

            }
            reader.Close();
            // 5. Clean up
            conn.Close();

            return person;
        }

        public Person GetPersonWithTransaction(String? username, SqlTransaction transaction, SqlConnection conn)
        {

            // 2. Creates a sql command that will be executed on the database
            SqlCommand cmd = conn.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = "SELECT * FROM Person where Username =  @Username";
            cmd.Parameters.AddWithValue("Username", username);

            // 3. Creates a datareader object to retrieve data
            SqlDataReader reader = cmd.ExecuteReader();

            // 4. Passes the data from the reader into a collection of Post objects
            Person person = new();

            while (reader.Read())
            {
                person.Username = reader.GetString(0);
                person.Password = reader.GetString(1);
                person.Points = reader.GetInt32(2);
                person.Usertype = reader.GetString(3);

            }
            reader.Close();

            return person;
        }


    }
}
