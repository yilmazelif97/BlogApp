﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentName { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }




    }
}
