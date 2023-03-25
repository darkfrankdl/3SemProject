using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IPersonDataAccess
    {
        public IEnumerable<Person> GetAll();
        public bool InsertPerson(Person person);
        public bool UpdatePerson(Person person);
        public bool Delete(Person person);
    }
}
