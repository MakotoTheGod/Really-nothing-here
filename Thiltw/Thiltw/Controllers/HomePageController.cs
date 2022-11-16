using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thiltw.Models;


namespace Thiltw.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        SQLTWEntities1 db = new SQLTWEntities1();
        public ActionResult Index()
        {
            //fix line 18 problem
            var books = db.Books.ToList();
           
            return View(books);
        }
        public ActionResult Details(int id)
        {
            //fix line 25 problem
            
            var books = db.Books.FirstOrDefault(l => l.Id == id);
            return View(books);
        }
    }
}