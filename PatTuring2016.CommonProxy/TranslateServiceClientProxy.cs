//-----------------------------------------------------------------------
// <copyright file="TranslateServiceClientProxy.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.CommonProxy
{
    public class TranslateServiceClientProxy : AbstractServiceClientFactory<ITranslateService>, ITranslateService
    {
        public NewMatchResponse GetData(NewMatchRequest usePatternRequest)
        {
            return Channel.GetData(usePatternRequest);
        }

        public GetTextResponse GetText(GetTextRequest request)
        {
            return Channel.GetText(request);
        }

        public GetScreenResponse GetCurrentScreenModel(GetScreenRequest userKey)
        {
            return Channel.GetCurrentScreenModel(userKey);
        }
    }
}