//-----------------------------------------------------------------------
// <copyright file="SplashController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.MVCWeb.Controllers
{
    using System.Web.Mvc;

    public class SplashController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
