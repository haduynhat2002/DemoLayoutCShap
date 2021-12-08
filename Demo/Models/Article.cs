using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Article
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Desscription { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublicDate { get; set; }
    }
}