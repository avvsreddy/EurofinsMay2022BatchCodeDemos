using KnowledgeHubPortal.Models.Data;
using KnowledgeHubPortal.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeHubPortal.Controllers
{
    public class CatagoriesController : Controller
    {

        IKnowledgeHubRepository repo = new KnowledgeHubRepository();

        // GET: Catagories
        public ActionResult Index()
        {
            // return a view to list all catagories

            // get all catagories
            var catagories = repo.GetCatagories();
            return View(catagories);
        }
        // ...../Catagories/Create
        [HttpGet]
        public ActionResult Create()
        {
            // return a view for collecting catagory info
            return View();
        }
        [HttpPost]
        public ActionResult Create(Catagory catagory)
        {
            // data validation
            if (!ModelState.IsValid)
                return View();

            repo.SaveCatagory(catagory);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            Catagory catagory = repo.GetCatagory(id);
            return View(catagory);
        }

        public ActionResult ConfirmDelete(int id)
        {
            repo.DeleteCatagory(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Catagory catagory = repo.GetCatagory(id);
            return View(catagory);
        }
        [HttpPost]
        public ActionResult Edit(Catagory catagoryToEdit)
        {
            repo.EditCatagory(catagoryToEdit);
            return RedirectToAction("Index");
        }
    }
}