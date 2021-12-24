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

        public List<Post> Last3postList()
        {
            return _db.Posts.OrderByDescending(s => s.Id).Take(3).ToList();
        }


        public List<Category> ListCategories()
        {
            return _db.Categories.ToList();
        }


        public Post Findbyid(int id)
        {
            return _db.Posts.Find(id);
        }

        public void AddComment(Comment comment)
        {
             _db.Comments.Add(comment);
            _db.SaveChanges();
        }

        public Category FindCategory(int id)
        {
            return _db.Categories.Find(id);
        }




    }
}
