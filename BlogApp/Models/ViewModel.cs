using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class ViewModel
    {

        public List<Comment> comments { get; set; } = new List<Comment>();

        public List<Post> posts { get; set; } = new List<Post>();

    }

    //list oluştur göndereceğin
}
