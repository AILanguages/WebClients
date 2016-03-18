//-----------------------------------------------------------------------
// <copyright file="SessionServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ServiceModel;
using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.ServiceProxy
{
    public class SessionService : ClientBase<ISessionService>, ISessionService
    {
        public GetIDResponse GetID(GetIDRequest usePatternRequest)
        {
            return Channel.GetID(usePatternRequest);
        }
    }
}