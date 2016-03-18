//-----------------------------------------------------------------------
// <copyright file="SamplesController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.MVC5Web.Models;
using PatTuring2016.ServiceProxy.Facades;
using System.Web.Mvc;

namespace PatTuring2016.MVC5Web.Controllers
{
    public class SamplesController : Controller
    {
        private readonly SettingsServiceFacade _settingsServiceFacade;
        private readonly SamplesServiceFacade _samplesService;

        public SamplesController(SamplesServiceFacade samplesService,
            SettingsServiceFacade settingsServiceFacade)
        {
            _samplesService = samplesService;
            _settingsServiceFacade = settingsServiceFacade;
        }

        public ActionResult Index()
        {
            var settings = _settingsServiceFacade.GetSettings();
            var samplesettings = _settingsServiceFacade.GetSampleSettings();

            var model = new SampleMatchViewModel
            {
                Settings = settings,
                SampleSettings = samplesettings,
                SampleMatchDisplay = _samplesService.GetHomePageView()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SampleMatchViewModel viewModel)
        {
            _settingsServiceFacade.UpdateSettings(viewModel.Settings, viewModel.SampleSettings);
            return RedirectToAction("Index");
        }

        public ActionResult SelectFile(int choice)
        {
            _samplesService.ChooseSampleFileFor(choice);

            return RedirectToAction("Index");
        }

        public ActionResult Select(int selection)
        {
            if (_samplesService.SelectSampleFor(selection))
            {
                return RedirectToAction("Index", "Demo");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int selection)
        {
            if (_samplesService.EditSampleFor(selection))
            {
                return RedirectToAction("Index", "Demo");
            }

            return RedirectToAction("Index");
        }
    }
}