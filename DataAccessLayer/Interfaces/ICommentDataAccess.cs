using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ICommentDataAccess
    {
        public IEnumerable<Comment> GetAll(DateTime postedAt, String username);
        public int AddComment(Comment comment);
        public bool DeleteComment(Comment comment);
        public bool UpdateComment(Comment comment);

    }
}
