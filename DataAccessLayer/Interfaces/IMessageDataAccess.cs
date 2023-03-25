using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IMessageDataAccess
    {
        public IEnumerable<Message> GetAll();
        public int AddMessage(Message message);
        public bool DeleteMessage(int id);
        public bool UpdateMessage(Message message);
    }
}
