//-----------------------------------------------------------------------
// <copyright file="DemoServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.CommonProxy;
using PatTuring2016.ServiceProxy.ViewModels;

namespace PatTuring2016.ServiceProxy.Facades
{
    public class DemoServiceFacade : GetaMatch
    {
        private readonly MatchService _demoClientProxy;
        private readonly BaseServiceFacade _baseServiceFacade;

        private delegate ChangeScreenResponse GetResponse(ChangeScreenRequest changeScreenRequest);

        public DemoServiceFacade(MatchService clientProxy, BaseServiceFacade baseServiceFacade)
        {
            _demoClientProxy = clientProxy;
            _baseServiceFacade = baseServiceFacade;
        }

        // 'Demo' Facade Methods
        public MatchTextPresentation GetText(string text)
        {
            var textToUse = new MatchTextPresentation { TextToUseFound = false };

            var request = new GetTextRequest { UserKey = _baseServiceFacade.UserKey, TextIn = text };
            var response = _demoClientProxy.GetText(request);

            if (response.Success)
            {
                textToUse.Match = response.Match;
                textToUse.EditFound = response.EditFound;
                textToUse.TextToUseFound = true;
            }

            return textToUse;
        }

        public string Restart()
        {
            var request = new CommandRequest { UserKey = _baseServiceFacade.UserKey, CommandNo = Command.Restart };
            var response = _demoClientProxy.Commands(request);

            return response.Edit != "exit" ? "FullScreen" : "Index";
        }

        public ScreenPresentation GetCurrentScreen()
        {
            var screenReturned = new ScreenPresentation();

            var request = new GetScreenRequest { UserKey = _baseServiceFacade.UserKey };
            var response = _demoClientProxy.GetCurrentScreenModel(request);

            if (response.Success)
            {
                screenReturned.ScreenFound = true;
                screenReturned.ScreenModel = response.ScreenModel;
                if (response.ScreenName == "Clause")
                {
                    if (response.ScreenModel.ScreenName == "Noun")
                    {
                        response.ScreenName = "Noun";
                    }
                }

                screenReturned.ScreenName = response.ScreenName;
                screenReturned.SimpleView = response.SimpleView;
            }
            else
            {
                screenReturned.ScreenFound = false;
                screenReturned.ScreenModel = null;
            }

            return screenReturned;
        }

        public string Back()
        {
            var request = new CommandRequest { UserKey = _baseServiceFacade.UserKey, CommandNo = Command.Back };
            var response = _demoClientProxy.Commands(request);

            return response.Edit != "exit" ? "FullScreen" : "Index";
        }

        public void SelectFor(int selection)
        {
            var request = new ChangeScreenRequest { UserKey = _baseServiceFacade.UserKey, Selection = selection };
            _demoClientProxy.SelectFor(request);
        }

        public void MoreDetailFor(int type)
        {
            var request = new ChangeScreenRequest { UserKey = _baseServiceFacade.UserKey, Type = type };
            _demoClientProxy.MoreDetailFor(request);
        }

        public void MoreChangeDetailFor(int type, int part)
        {
            MoreDetailFor(_demoClientProxy.MoreChangeDetailFor, type, part);
        }

        public void MoreGridDetailFor(int type, int part)
        {
            MoreDetailFor(_demoClientProxy.MoreGridDetailFor, type, part);
        }

        public void MoreGridSenseFor(int type, int part)
        {
            MoreDetailFor(_demoClientProxy.MoreGridSenseFor, type, part);
        }

        public void MoreSenseFor(int type, int part)
        {
            MoreDetailFor(_demoClientProxy.MoreSenseFor, type, part);
        }

        private void MoreDetailFor(GetResponse getResponse, int type, int part)
        {
            var request = new ChangeScreenRequest { UserKey = _baseServiceFacade.UserKey, Type = type, Part = part };
            getResponse(request);
        }

        public void SelectWordFor()
        {
            var request = new ChangeScreenRequest { UserKey = _baseServiceFacade.UserKey };
            _demoClientProxy.SelectWordFor(request);
        }

        public MatchPatternPresentation GetMatchFor(Match match)
        {
            var request = new NewMatchRequest { DataToMatch = match, UserKey = _baseServiceFacade.UserKey };
            return GetAMatchFor(match, _demoClientProxy.GetData(request));
        }
    }
}