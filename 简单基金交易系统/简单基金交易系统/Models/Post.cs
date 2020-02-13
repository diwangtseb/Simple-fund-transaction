using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 简单基金交易系统.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Createdata { get; set; }
        public DateTime ModifDate { get; set; }
        public string Author { get; set; }

        
    }
}