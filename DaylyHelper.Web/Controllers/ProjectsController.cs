using DaylyHelper.Data.Services;
using DaylyHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaylyHelper.Web.Controllers
{
    public class ProjectsController : Controller
    {
        IDayHelperData db;

        public ProjectsController(IDayHelperData db)
        {
            this.db = db;
        }
        // GET: Projects
        public ActionResult Index()
        {

            var model = db.GetAllProjects();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            if(ModelState.IsValid)
            {
                db.AddProject(project);
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.GetProject(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                db.Update(project);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult Details(int id)
        {
            var model = db.GetProject(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult AddNote(int id,Note note)
        {
            db.AddNote(id,note);
            return RedirectToAction($"Details/{id}");
        }
        public ActionResult Delete(int id)
        {
            db.DeleteProject(id);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteNote(int id)
        {
            db.DeleteNote(id);
            return RedirectToAction("Index");
        }


    }
}