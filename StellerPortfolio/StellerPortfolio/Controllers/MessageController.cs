using StellerPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerPortfolio.Controllers
{
    public class MessageController : Controller
    {
        StellerAcunMedyaDbEntities2 db = new StellerAcunMedyaDbEntities2();
        public ActionResult Index()
        {
            var values = db.TblMessage.Where(x => x.isRead == false).ToList();
            return View(values);
        }
        public ActionResult MessageDetail(int id)
        {
            var message = db.TblMessage.Find(id);
            message.isRead = true;
            db.SaveChanges();
            return View(message);
        }

        public ActionResult ReadMessages()
        {
            var values = db.TblMessage.Where(x => x.isRead == true).ToList();
            return View(values);
        }

    }
}