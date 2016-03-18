//-----------------------------------------------------------------------
// <copyright file="BaseTranslateServiceFacade.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.CommonProxy
{
    public abstract class BaseTranslateServiceFacade
    {
        private readonly ITranslateService _translateClientProxy;

        protected BaseTranslateServiceFacade(ITranslateService translateService)
        {
            _translateClientProxy = translateService;
        }

        protected abstract GetScreenRequest GetScreenRequest();
        protected abstract NewMatchRequest GetNewMatchRequest(Match match);

        protected GetTextResponse GetTextResponse(GetTextRequest request)
        {
            return _translateClientProxy.GetText(request);
        }

        public ScreenPresentation GetCurrentScreen()
        {
            var screenReturned = new ScreenPresentation();

            var request = GetScreenRequest();
            var response = _translateClientProxy.GetCurrentScreenModel(request);

            if (response.Success)
            {
                screenReturned.ScreenFound = true;
                screenReturned.ScreenModel = response.ScreenModel;
                screenReturned.ScreenName = response.ScreenName;
            }
            else
            {
                screenReturned.ScreenFound = false;
                screenReturned.ScreenModel = null;
            }

            return screenReturned;
        }

        public MatchPatternPresentation GetMatchFor(Match match)
        {
            var request = GetNewMatchRequest(match);
            return GetAMatchFor(match, _translateClientProxy.GetData(request));
        }

        private MatchPatternPresentation GetAMatchFor(Match match, NewMatchResponse response)
        {
            var matchPattern = new MatchPatternPresentation();

            if (response.Success)
            {
                matchPattern.MatchesSuccessfullyFound = true;
                matchPattern.MatchId = response.UserKey;
                matchPattern.ExpiryDate = response.ExpirationDate;
                matchPattern.MenuType = response.MenuType;
            }
            else
            {
                matchPattern.MatchesSuccessfullyFound = false;
                matchPattern.Message = response.Message;
                matchPattern.Edit = match;
            }

            return matchPattern;
        }
    }
}