//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Web.Mvc;

namespace PatTuring2016.MVC5Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult Releases()
        {
            return View();
        }
    }
}
