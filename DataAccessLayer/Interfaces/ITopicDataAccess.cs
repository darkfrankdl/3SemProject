using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces;
        public interface ITopicDataAccess
        {
             public IEnumerable<Topic> GetAll();
             public bool Insert(Topic topic);
             public bool Delete(Topic topic);
             public bool Update(Topic topic);

        }
 

