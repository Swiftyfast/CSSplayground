using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSSPlayground.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProtagonistOne()
        {
            return View();
        }

        public ActionResult ProtagonistTwo()
        {
            return View();
        }

        public ActionResult ProtagonistThree()
        {
            return View();
        }

        public ActionResult AntagonistShark()
        {
            return View();
        }

        public ActionResult AntagonistDraldan()
        {
            return View();
        }

        public ActionResult AntagonistTimeEvent()
        {
            return View();
        }

        public ActionResult MidnightCards()
        {
            return View();
        }
        //NOTE we cannot just create a controller, we will probably have to create a model first.
        //edit
        //Codepen?
        //Look to notes to figure out new controllers
    }
}