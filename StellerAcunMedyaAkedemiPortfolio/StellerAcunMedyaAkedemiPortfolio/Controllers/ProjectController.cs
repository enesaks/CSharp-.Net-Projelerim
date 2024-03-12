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
    }
}