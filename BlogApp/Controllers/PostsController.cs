using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    {

        ApplicationDbContext _db = new ApplicationDbContext();



        //Tıklanan posta yönlendirme yapan fonksiyon view componentten
        public IActionResult GetPostsbyid(int? id)
        {
            List<Post> posts = _db.Posts.Where(x => x.Id == id).ToList();
            return View(posts);
        }


    }
}
