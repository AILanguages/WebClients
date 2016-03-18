//-----------------------------------------------------------------------
// <copyright file="IMatchService.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.DataContracts;
using System.ServiceModel;

namespace PatTuring2016.Common.Contracts
{
    [ServiceContract]
    public interface IMatchService
    {
        //demo
        [OperationContract]
        NewMatchResponse GetData(NewMatchRequest usePatternRequest);

        [OperationContract]
        GetScreenResponse GetCurrentScreenModel(GetScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse SelectFor(ChangeScreenRequest userKey);

        [OperationContract]
        CommandResponse Commands(CommandRequest request);

        [OperationContract]
        ChangeScreenResponse MoreGridSenseFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreSenseFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse SelectWordFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreGridDetailFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreChangeDetailFor(ChangeScreenRequest userKey);

        [OperationContract]
        ChangeScreenResponse MoreDetailFor(ChangeScreenRequest userKey);

        [OperationContract]
        GetTextResponse GetText(GetTextRequest request);
    }
}