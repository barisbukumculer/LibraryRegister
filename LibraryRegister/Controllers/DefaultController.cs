using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryRegister.Models.Entity;

namespace LibraryRegister.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        LibraryDbEntities db=new LibraryDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(TBLKAYIT p1)
        {
            db.TBLKAYIT.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}