//-----------------------------------------------------------------------
// <copyright file="ConverseServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ServiceProxy.Facades
{
    using CommonProxy;
    using DataContracts;
    using ScreenModels;
    using ScreenModels.Conversation;
    using System.Web;

    public class ConverseServiceFacade
    {
        private readonly ConverseServiceClientProxy _converseClientProxy;
        private readonly BaseServiceFacade _baseServiceFacade;

        public ConverseServiceFacade(ConverseServiceClientProxy samplesService, BaseServiceFacade baseServiceFacade)
        {
            _converseClientProxy = samplesService;
            _baseServiceFacade = baseServiceFacade;
        }

        public ConversationData UpdateConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = _baseServiceFacade.UserKey, DataToMatch = match };

            var response = _converseClientProxy.GetConversationData(request);

            if (response.UserKey != _baseServiceFacade.UserKey)
            {
                HttpContext.Current.Session["UserKey"] = response.UserKey;
            }

            return response.Conversation;
        }

        public ConversationData GetContext(Match match)
        {
            var request = new NewMatchRequest { UserKey = _baseServiceFacade.UserKey, DataToMatch = match };

            var response = _converseClientProxy.GetContext(request);

            if (response.UserKey != _baseServiceFacade.UserKey)
            {
                HttpContext.Current.Session["UserKey"] = response.UserKey;
            }

            return response.Conversation;
        }

        public void RestartConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = _baseServiceFacade.UserKey, DataToMatch = match };

            var response = _converseClientProxy.RestartConversation(request);

            if (response.UserKey != _baseServiceFacade.UserKey)
            {
                HttpContext.Current.Session["UserKey"] = response.UserKey;
            }
        }
    }
}