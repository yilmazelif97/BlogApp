﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class TagPostRelation
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}
