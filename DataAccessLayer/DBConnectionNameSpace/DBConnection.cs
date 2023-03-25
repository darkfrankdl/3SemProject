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
            _connectionStringBuilder.DataSource = "hildur.ucn.dk";
            _connectionStringBuilder.InitialCatalog = "DMA-CSD-S212_1089449";
            _connectionStringBuilder.UserID = "DMA-CSD-S212_1089449";
            _connectionStringBuilder.Password = "Password1!";
            _connectionStringBuilder.Encrypt = false;
            _connectionStringBuilder.IntegratedSecurity = false;
        }

        /*public sealed class Singleton
        {
            private static readonly Lazy<Singleton> lazy =
                new Lazy<Singleton>(() => new Singleton());

            public static Singleton Instance { get { return lazy.Value; } }

            private Singleton()
            {
            }
        }
        */


        //private DBConn()
        //{
        //}
        //private static readonly Lazy<DBConn> lazy = new Lazy<DBConn>(() => new DBConn());
        //public static Singleton5 Instance
        //{
        //    get
        //    {
        //        return lazy.Value;
        //    }
        //}


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

