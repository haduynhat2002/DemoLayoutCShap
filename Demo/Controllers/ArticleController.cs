using Demo.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Models
{
    public class ArticleController : Controller
    {
        // GET: Article
        private static List<Article> listArticles = new List<Article>();
        public ActionResult Index()
        {
            return View(listArticles);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(ArticleModel articleModel)
        {
            var article = new Article()
            {
                Title = articleModel.Title,
                Desscription = articleModel.Desscription,
                Author = articleModel.Author,
                Content = articleModel.Content,
                PublicDate = articleModel.PublicDate
            };
            listArticles.Add(article);
            return Redirect("Index");
        }
    }
}