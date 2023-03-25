using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IPostDataAccess
    { 
        public IEnumerable<Post> GetAll();

        public Post GetPost(string? postUsername, string postDateTime);

        public IEnumerable<Post> GetPostsFromTopicWithID(String? Categoryname);
        public bool Insert(Post post);
        public bool Delete(Post post);
        public bool Update(Post post);

    }
}
