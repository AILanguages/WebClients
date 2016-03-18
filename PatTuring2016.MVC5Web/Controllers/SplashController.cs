//-----------------------------------------------------------------------
// <copyright file="SplashController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Web.Mvc;

namespace PatTuring2016.MVC5Web.Controllers
{
    public class SplashController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
