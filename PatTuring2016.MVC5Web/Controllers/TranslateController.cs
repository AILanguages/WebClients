//-----------------------------------------------------------------------
// <copyright file="TranslateController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;
using PatTuring2016.Common.ScreenModels.FullScreenModels;
using PatTuring2016.ServiceProxy.Facades;
using System.Web.Mvc;

namespace PatTuring2016.MVC5Web.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class TranslateController : Controller
    {
        private readonly SettingsServiceFacade _settingsServiceFacade;
        private readonly TranslateServiceFacade _translateServiceFacade;

        public TranslateController(TranslateServiceFacade translateServiceFacade,
            SettingsServiceFacade settingsServiceFacade)
        {
            _translateServiceFacade = translateServiceFacade;
            _settingsServiceFacade = settingsServiceFacade;
        }

        [HttpGet]
        public ActionResult Index(string text)
        {
            var tvm = new TranslateViewModel
            {
                LastSearch = text,
                Match = _translateServiceFacade.GetText(text).Match,
                MatchSettings = _settingsServiceFacade.GetSettings(),
                SampleSettings = _settingsServiceFacade.GetSampleSettings()
            };

            return View(tvm);
        }

        [HttpPost]
        public ActionResult Index(TranslateViewModel tvm)
        {
            tvm.MatchSettings.ShowSentences = false; // required for matching
            _settingsServiceFacade.UpdateSettings(tvm.MatchSettings, tvm.SampleSettings);
            tvm.LastSearch = tvm.Match.TextIn;

            var getmatch = _translateServiceFacade.GetMatchFor(tvm.Match);

            if (getmatch.MatchesSuccessfullyFound)
            {
                var screen = _translateServiceFacade.GetCurrentScreen();
                var clause = screen.ScreenModel as FullClauseScreenModel;

                // let's add to the existing list
                var tp = new TranslatePair
                {
                    Source = tvm.LastSearch,
                    Target = clause.Translation
                };

                tvm.Translations.Add(tp);
            }

            return View(tvm);
        }
    }
}