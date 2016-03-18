//-----------------------------------------------------------------------
// <copyright file="ConverseController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Web.Mvc;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.ServiceProxy.Facades;

namespace PatTuring2016.MVC5Web.Controllers
{
    public class ConverseController : Controller
    {
        private readonly ConverseServiceFacade _converseService;

        public ConverseController(ConverseServiceFacade converseService)
        {
            _converseService = converseService;
        }

        public ActionResult Index(ConverseViewModel model)
        {
            var match = new Match();

            if (model != null)
            {
                if (model.Match != null)
                {
                    if (!string.IsNullOrWhiteSpace(model.Match.TextIn))
                    {
                        match.TextIn = model.Match.TextIn;
                    }
                }
            }

            var getmatch = _converseService.UpdateConversation(match);
            var newmodel = new ConverseViewModel { Conversation = getmatch, Match = new Match() };

            return View(newmodel);
        }

        public ActionResult Context(ConverseViewModel model)
        {
            var match = new Match { TextIn = "Context" };

            if (model != null)
            {
                if (model.Match != null)
                {
                    if (!string.IsNullOrWhiteSpace(model.Match.TextIn))
                    {
                        match.TextIn = model.Match.TextIn;
                    }
                }
            }

            var getmatch = _converseService.GetContext(match);
            var newmodel = new ConverseViewModel { Conversation = getmatch, Match = new Match() };

            return View(newmodel);
        }

        public ActionResult Tracker(ConverseViewModel model)
        {
            var match = new Match { TextIn = "Context" };

            if (model != null)
            {
                if (model.Match != null)
                {
                    if (!string.IsNullOrWhiteSpace(model.Match.TextIn))
                    {
                        match.TextIn = model.Match.TextIn;
                    }
                }
            }

            var getmatch = _converseService.GetContext(match);
            var newmodel = new ConverseViewModel { Conversation = getmatch, Match = new Match() };

            return View(newmodel);
        }

        public ActionResult Restart(ConverseViewModel model)
        {
            var match = new Match();

            if (model != null)
            {
                if (model.Match != null)
                {
                    if (!string.IsNullOrWhiteSpace(model.Match.TextIn))
                    {
                        match.TextIn = model.Match.TextIn;
                    }
                }
            }

            _converseService.RestartConversation(match);

            return RedirectToAction("Index");
        }
    }
}