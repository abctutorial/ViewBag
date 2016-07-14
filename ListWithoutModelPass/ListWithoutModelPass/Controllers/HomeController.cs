using ListWithoutModelPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListWithoutModelPass.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ContactDBEntities db = new ContactDBEntities();
            ViewBag.ItemData = db.tblAddresses.ToList();
            return View();
        }
    }
}