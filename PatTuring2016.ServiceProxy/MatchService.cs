//-----------------------------------------------------------------------
// <copyright file="DemoServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ServiceModel;
using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.ServiceProxy
{
    public class MatchService : ClientBase<IMatchService>, IMatchService
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

        public ChangeScreenResponse SelectFor(ChangeScreenRequest request)
        {
            return Channel.SelectFor(request);
        }

        public CommandResponse Commands(CommandRequest request)
        {
            return Channel.Commands(request);
        }

        public ChangeScreenResponse MoreDetailFor(ChangeScreenRequest request)
        {
            return Channel.MoreDetailFor(request);
        }

        public ChangeScreenResponse MoreChangeDetailFor(ChangeScreenRequest request)
        {
            return Channel.MoreChangeDetailFor(request);
        }

        public ChangeScreenResponse MoreGridDetailFor(ChangeScreenRequest request)
        {
            return Channel.MoreGridDetailFor(request);
        }

        public ChangeScreenResponse MoreGridSenseFor(ChangeScreenRequest request)
        {
            return Channel.MoreGridSenseFor(request);
        }

        public ChangeScreenResponse MoreSenseFor(ChangeScreenRequest request)
        {
            return Channel.MoreSenseFor(request);
        }

        public ChangeScreenResponse SelectWordFor(ChangeScreenRequest request)
        {
            return Channel.SelectWordFor(request);
        }
    }
}