using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer.DBConnectionNameSpace
{
    public sealed class DBConnection
    {

        private SqlConnectionStringBuilder _connectionStringBuilder;
        private static DBConnection? s_dbConnection;
        

        public SqlConnectionStringBuilder DBConnectionString { get { return _connectionStringBuilder; } }


        private DBConnection()
        {
            _connectionStringBuilder = new();
            _connectionStringBuilder.DataSource = "localhost\\sqlexpress";
            _connectionStringBuilder.InitialCatalog = "projekt";
            _connectionStringBuilder.UserID = "";
            _connectionStringBuilder.Password = "";
            _connectionStringBuilder.Encrypt = false;
            _connectionStringBuilder.IntegratedSecurity = true;
        }


        public static DBConnection GetInstance()
        {
            string padlock = "lock";
            lock (padlock)
            {
                if (s_dbConnection == null)
                {
                    s_dbConnection = new DBConnection();
                }
                return s_dbConnection;
            }
        }

    }
}

