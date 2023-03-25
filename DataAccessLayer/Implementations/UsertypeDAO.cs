using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DBConnectionNameSpace;
using DataAccessLayer.Models;

namespace DataAccessLayer.Implementations
{
    public class UsertypeDAO
    {
        private DBConnection _dbConnection;
        public UsertypeDAO()
        {
           _dbConnection = DBConnection.GetInstance();
        }
        public bool Insert (Usertype usertype)
        {
            SqlConnection conn = new SqlConnection(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into usertype values (@Usertype);";
            cmd.Parameters.AddWithValue("Usertype",usertype.Type);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected ==1;
        }

        public bool Delete(Usertype usertype)
        {
            SqlConnection conn = new SqlConnection(_dbConnection.DBConnectionString.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "delete from usertype where usertype = @usertype;";
            cmd.Parameters.AddWithValue("Usertype", usertype.Type);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected == 1;
        }


    }
}
