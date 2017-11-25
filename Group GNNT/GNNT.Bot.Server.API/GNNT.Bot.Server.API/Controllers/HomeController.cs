using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GNNT.Bot.Server.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            AskPlacesController askPlace = new AskPlacesController();
            askPlace.Post();
            return View();
        }
    }
}
