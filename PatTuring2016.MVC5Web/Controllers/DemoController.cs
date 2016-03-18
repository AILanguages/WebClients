//-----------------------------------------------------------------------
// <copyright file="DemoController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels.FullScreenModels;
using PatTuring2016.ServiceProxy.Facades;
using PatTuring2016.ServiceProxy.ViewModels;
using System.Web.Mvc;

namespace PatTuring2016.MVC5Web.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class DemoController : Controller
    {
        private readonly DemoServiceFacade _demoServiceFacade;
        private readonly SettingsServiceFacade _settingsServiceFacade;

        public DemoController(DemoServiceFacade demoServiceFacade, SettingsServiceFacade settingsServiceFacade)
        {
            _demoServiceFacade = demoServiceFacade;
            _settingsServiceFacade = settingsServiceFacade;
        }

        [HttpGet]
        public ActionResult Index(string text)
        {
            var getText = _demoServiceFacade.GetText(text);
            var settings = _settingsServiceFacade.GetSettings();
            var samplesettings = _settingsServiceFacade.GetSampleSettings();

            if (getText != null)
            {
                var demo = new DemoViewModel { Match = getText.Match, Settings = settings, SampleSettings = samplesettings };

                if (getText.EditFound)
                {
                    return View(demo);
                }
            }
            else
            {
                return View();
            }

            var demo1 = new DemoViewModel { Match = getText.Match, Settings = settings, SampleSettings = samplesettings };

            return getText.TextToUseFound ? Index(demo1) : View();
        }

        [HttpPost]
        public ActionResult Index(DemoViewModel viewModel)
        {
            _settingsServiceFacade.UpdateSettings(viewModel.Settings, viewModel.SampleSettings);

            var getmatch = _demoServiceFacade.GetMatchFor(viewModel.Match);

            if (getmatch.MatchesSuccessfullyFound)
            {
                return RedirectToAction(getmatch.MenuType);
            }

            // no match - display for edit
            ViewBag.ErrorMessage = getmatch.Message;

            return View(viewModel);
        }

        public ActionResult Back()
        {
            return RedirectToAction(_demoServiceFacade.Back());
        }

        public ActionResult Restart()
        {
            return RedirectToAction(_demoServiceFacade.Restart());
        }

        public ActionResult Select(int selection)
        {
            _demoServiceFacade.SelectFor(selection);
            return RedirectToAction("FullScreen");
        }

        public ActionResult SelectWord()
        {
            _demoServiceFacade.SelectWordFor();
            return RedirectToAction("FullScreen");
        }

        public ActionResult MoreDetail(int type)
        {
            _demoServiceFacade.MoreDetailFor(type);
            return RedirectToAction("FullScreen");
        }

        public ActionResult MoreChangeDetail(int type, int part)
        {
            _demoServiceFacade.MoreChangeDetailFor(type, part);
            return RedirectToAction("FullScreen");
        }
        public ActionResult MoreGridDetail(int type, int part)
        {
            _demoServiceFacade.MoreGridDetailFor(type, part);
            return RedirectToAction("FullScreen");
        }

        public ActionResult MoreGridSense(int type, int part)
        {
            _demoServiceFacade.MoreGridSenseFor(type, part);
            return RedirectToAction("FullScreen");
        }

        public ActionResult MoreSense(int type, int part)
        {
            _demoServiceFacade.MoreSenseFor(type, part);
            return RedirectToAction("FullScreen");
        }

        public ActionResult Sentences()
        {
            var screen = _demoServiceFacade.GetCurrentScreen();
            return View(screen.ScreenModel as StandardScreenModel);
        }

        public ActionResult ClauseStart()
        {
            var screen = _demoServiceFacade.GetCurrentScreen();
            return !screen.SimpleView ? View(screen.ScreenModel as FullClauseScreenModel) : View("SimpleClauseStart", screen.ScreenModel as FullClauseScreenModel);
        }

        public ActionResult FullScreen()
        {
            var screen = _demoServiceFacade.GetCurrentScreen();
            switch (screen.ScreenName)
            {
                case "Word": return PartialView("Word", screen.ScreenModel as WordScreenModel);
                case "Fullword": return PartialView("FullWord", screen.ScreenModel as WordScreenModel);
                case "Sense": return PartialView("Sense", screen.ScreenModel as SenseScreenModel);
                case "Senses": return PartialView("Senses", screen.ScreenModel as SensesScreenModel);
                case "Sentence": return PartialView("Sentence", screen.ScreenModel as SentenceScreenModel);
                case "Phrase": return PartialView("Phrase", screen.ScreenModel as PhraseScreenModel);
                case "Clause":
                    {
                        var model = (FullClauseScreenModel)screen.ScreenModel;
                        return !screen.SimpleView ? PartialView("Partials/Clause", model) : PartialView("SimplePartials/SimpleClause", model);
                    }
                case "Noun":
                    {
                        var model = (FullNounScreenModel)screen.ScreenModel;
                        return !screen.SimpleView ? PartialView("NounClause", model) : PartialView("SimplePartials/SimpleNounClause", model);
                    }

                default: return PartialView(screen.ScreenName, screen.ScreenModel);
            }
        }
    }
}