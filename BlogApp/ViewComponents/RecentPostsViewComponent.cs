using BlogApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogApp.ViewComponents
{

    //view component dependecny injection sağlar 
    public class RecentPostsViewComponent : ViewComponent
    {
        private readonly PostRepository _postrepository;

        public RecentPostsViewComponent(PostRepository postrepository)
        {
            _postrepository = postrepository;
        }

        public async Task<IViewComponentResult> Invokeasync()
        {
            var result = _postrepository.Last5postList();
            return View(await Task.FromResult(result));
        }

    }
}
