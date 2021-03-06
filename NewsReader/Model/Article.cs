﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReader.Model
{
   
    public class Article
    {
        public int Id { get; set; }
        public int Feed { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime PublishDate { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public List<string> Related { get; set; }
        public List<Category> Categories { get; set; }
        public bool IsLiked { get; set; }
    }
}
