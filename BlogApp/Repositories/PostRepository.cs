using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repositories
{
    public class PostRepository
    {
        private readonly ApplicationDbContext _db;
        public PostRepository()
        {
            _db = new ApplicationDbContext();
        }
         public List<Post> List()
        {
            return _db.Posts.ToList();
        }
    }
}
