using BlogApp.Models;
using BlogApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    {

        ApplicationDbContext _db = new ApplicationDbContext();
        private readonly PostRepository _postrepository;


        public PostsController(PostRepository rp)
        {
            _postrepository = rp;
        }



        //Tıklanan posta yönlendirme yapan fonksiyon view componentten


        [HttpGet]
        public IActionResult GetPostsbyid(int id)
        {

            ViewModel d = new ViewModel();

            var item = _postrepository.Findbyid(id); //3 geliyor mesela post id burda 

            d.posts.Add(item);

            var comment =_db.Comments.Where(x => x.Id == item.CommentId);


            foreach (var i in comment)
            {
                d.comments.Add(i);
            }

           


            return View(d);
        }



    }
}
