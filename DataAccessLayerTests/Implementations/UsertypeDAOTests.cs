using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Implementations.Tests
{
    [TestClass()]
    public class UsertypeDAOTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            // arrange 
            Usertype usertype = new Usertype();
            usertype.Type = "Usertype";

            UsertypeDAO usertypeDAO = new UsertypeDAO();
            // act 

            bool x = usertypeDAO.Insert(usertype);
            // assert
            Assert.IsTrue(x);
            usertypeDAO.Delete(usertype);

        }
    }
}