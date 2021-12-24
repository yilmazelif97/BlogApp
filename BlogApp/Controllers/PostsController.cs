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

        [HttpPost]
        public IActionResult SearchPost(string text)
        {
            List<Post> searchedpsot = _db.Posts.Where(x => x.Content.Contains(text) || x.Title.Contains(text)).ToList();

            if(searchedpsot == null)
            {
                throw new System.Exception("Aradığınız makale bulunamamakta.");
            }

            return View(searchedpsot);
        }


        [HttpPost]
        public IActionResult CreateComment(int id,string commentname, string contentofcomment )
        {

            var routeValues = Url.ActionContext.RouteData.Values;
            


            var item = _postrepository.Findbyid(id);

            Comment com = new Comment();

            Post p = new Post();

            var k = id;

            com.CommentName = commentname;
            com.Content = contentofcomment;
            com.PublishDate = System.DateTime.UtcNow;


           
            _postrepository.AddComment(com);



            return View();

        }


        [HttpGet]
        public IActionResult GetCategorybyid(int id)
        {

            Category c = new Category();

            var item = _postrepository.FindCategory(id); //3 geliyor mesela post id burda 
            List<Post> dene = _db.Posts.Where(x => x.CategoryId == id).ToList();

          

            return View(dene);
        }



    }
}
