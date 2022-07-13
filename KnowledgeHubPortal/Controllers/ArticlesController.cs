using KnowledgeHubPortal.Models.Data;
using KnowledgeHubPortal.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHubPortal.Controllers
{
    public class ArticlesController : Controller
    {

        IKnowledgeHubRepository repo = new KnowledgeHubRepository();
        // GET: Articles
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Submit()
        {
            List<Catagory> catagories = repo.GetCatagories();
            ViewBag.CatagoryId = catagories;

            return View();
        }
        [HttpPost]
        public ActionResult Submit(Article articleToSubmit)
        {
            if (!ModelState.IsValid)
            {
                List<Catagory> catagories = repo.GetCatagories();
                ViewBag.CatagoryId = catagories;

                return View();
            }

            articleToSubmit.IsApproved = false;
            articleToSubmit.PostedBy = User.Identity.Name;
            articleToSubmit.PostedOn = DateTime.Now;


            repo.SubmitArticle(articleToSubmit);

            TempData["Message"] = $"You have submitted the article [{articleToSubmit.Title}] successfully. However Admin will approve your articles later";
            
            return RedirectToAction("Index", "Home");
        }


        public ActionResult Approve()
        {
            List<Catagory> catagories = repo.GetCatagories();
            ViewBag.CatagoryId = catagories;

            List<Article> newArticlesForApprove = repo.GetArticlesForApprove();


            return View(newArticlesForApprove);
        }
    }
}