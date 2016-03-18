//-----------------------------------------------------------------------
// <copyright file="ConverseServiceClientProxy.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.CommonProxy
{
    public class ConverseServiceClientProxy : AbstractServiceClientFactory<IConverseService>, IConverseService
    {
        public ConverseResponse GetConversationData(NewMatchRequest request)
        {
            return Channel.GetConversationData(request);
        }

        public ConverseResponse GetContext(NewMatchRequest request)
        {
            return Channel.GetContext(request);
        }

        public ConverseResponse RestartConversation(NewMatchRequest request)
        {
            return Channel.RestartConversation(request);
        }
    }
}