using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StellerAcunMedyaAkedemiPortfolio.Models;

namespace StellerAcunMedyaAkedemiPortfolio.Controllers
{
    public class ProjectController : Controller
    {

        StellerAcunMedyaDbEntities db = new StellerAcunMedyaDbEntities();

        public ActionResult Index()
        {

            var projectList = db.TblProject.ToList();
              
            return View(projectList);
        }
<<<<<<< HEAD

        public ActionResult DeleteProject(int id)
        {
            var project = db.TblProject.Find(id);
            db.TblProject.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProject project)
        {
            db.TblProject.Add(project); 
            db.SaveChanges(); 
            return RedirectToAction("Index");
        }

        




=======
>>>>>>> 2081163c5380347a73ffae64e3b9d4ffb1af7473
    }
}