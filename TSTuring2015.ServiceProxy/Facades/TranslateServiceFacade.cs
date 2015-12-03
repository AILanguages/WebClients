﻿//-----------------------------------------------------------------------
// <copyright file="TranslateServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ServiceProxy.Facades
{
    using CommonProxy;
    using DataContracts;
    using ScreenModels;
    using ViewModels;

    public class TranslateServiceFacade : BaseTranslateServiceFacade
    {
        private readonly BaseServiceFacade _baseServiceFacade;

        public TranslateServiceFacade(TranslateServiceClientProxy clientProxy, BaseServiceFacade baseServiceFacade)
            : base(clientProxy)
        {
            _baseServiceFacade = baseServiceFacade;
        }

        // 'Demo' Facade Methods
        public MatchTextPresentation GetText(string text)
        {
            var textToUse = new MatchTextPresentation { TextToUseFound = false };

            var request = new GetTextRequest { UserKey = _baseServiceFacade.UserKey, TextIn = text };
            var response = GetTextResponse(request);

            if (response.Success)
            {
                textToUse.Match = response.Match;
                textToUse.EditFound = response.EditFound;
                textToUse.TextToUseFound = true;
            }

            return textToUse;
        }

        protected override GetScreenRequest GetScreenRequest()
        {
            return new GetScreenRequest { UserKey = _baseServiceFacade.UserKey };
        }

        protected override NewMatchRequest GetNewMatchRequest(Match match)
        {
            return new NewMatchRequest { DataToMatch = match, UserKey = _baseServiceFacade.UserKey };
        }
    }
}