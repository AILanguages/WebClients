//-----------------------------------------------------------------------
// <copyright file="SettingsController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;
using PatTuring2016.ServiceProxy.Facades;
using System.Web.Mvc;

namespace PatTuring2016.MVC5Web.Controllers
{
    public class SettingsController : Controller
    {
        private readonly SettingsServiceFacade _settingsServiceFacade;

        public SettingsController(SettingsServiceFacade settingsServiceFacade)
        {
            _settingsServiceFacade = settingsServiceFacade;
        }

        public ActionResult Index()
        {
            return GetSpecificView("Demonstration");
        }

        [HttpPost]
        public ActionResult Index(TranslateViewModel settings)
        {
            var errorResult = CheckError(settings);
            return errorResult ?? RedirectToAction("Index", "Demo");
        }

        public ActionResult Converse()
        {
            return GetSpecificView("Conversation");
        }

        [HttpPost]
        public ActionResult Converse(TranslateViewModel settings)
        {
            var errorResult = CheckError(settings);
            return errorResult ?? RedirectToAction("Index", "Converse");
        }

        public ActionResult Translate()
        {
            return GetSpecificView("Translation");
        }

        [HttpPost]
        public ActionResult Translate(TranslateViewModel settings)
        {
            var errorResult = CheckError(settings);
            return errorResult ?? RedirectToAction("Index", "Translate");
        }

        private ActionResult CheckError(TranslateViewModel settings)
        {
            if (!TryUpdateModel(settings))
            {
                {
                    return View(settings);
                }
            }

            _settingsServiceFacade.UpdateSettings(settings.MatchSettings, settings.SampleSettings);

            return null;
        }

        private ActionResult GetSpecificView(string passthrough)
        {
            ViewBag.Passthrough = passthrough;
            var settings = _settingsServiceFacade.GetSettings();
            var samples = _settingsServiceFacade.GetSampleSettings();
            var tvm = new TranslateViewModel { MatchSettings = settings, SampleSettings = samples };

            return View("Index", tvm);
        }
    }
}
