using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowcaseA.Controllers
{
    [AllowAnonymous]
    public class SPAController : Controller
    {
        // GET: SPA
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Angular()
        {

             return View();
    
        }
        public ActionResult Jquery()
        {
            return View();
        }
        public ActionResult BootStrap()
        {
            return View();
        }
        public ActionResult MongoDb()
        {
            return View();
        }
        // remove  before release
        public ViewResult pjquery()
        {
            return View();

        }
        public ViewResult pbootstrap()
        {
            return View();
        }
        public ViewResult pangular()
        {
            return View();
        }

        public ViewResult pmongodb()
        {
            return View();
        }

        public ViewResult carousel()
        {
            return View();
        }
        public ViewResult scrollSpy()
        {
            return View();
        }
        public ViewResult Collapseable()
        {
            return View();
        }
        public ViewResult ToggableTabs()
        {
            return View();
        }
        public ViewResult modals()
        {
            return View();
        }
    }
}