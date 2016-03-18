//-----------------------------------------------------------------------
// <copyright file="ITranslateService.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ServiceModel;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.Common.Contracts
{
    [ServiceContract(Namespace = "http://demo.pat.ai/")]
    public interface ITranslateService
    {
        //demo
        [OperationContract]
        NewMatchResponse GetData(NewMatchRequest usePatternRequest);

        [OperationContract]
        GetScreenResponse GetCurrentScreenModel(GetScreenRequest userKey);

        [OperationContract]
        GetTextResponse GetText(GetTextRequest request);
    }
}