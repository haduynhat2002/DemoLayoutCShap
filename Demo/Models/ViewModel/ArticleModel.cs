using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models.ViewModel
{
    public class ArticleModel
    {
        [Key]

        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter desscription")]
        public string Desscription { get; set; }
        [Required(ErrorMessage = "Please enter content")]
        public string Content { get; set; }
       
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter author")]
        public DateTime PublicDate { get; set; }
       
    }
}