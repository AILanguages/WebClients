//-----------------------------------------------------------------------
// <copyright file="AbstractServiceClientFactory.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.ServiceModel;

namespace PatTuring2016.CommonProxy
{
    public class AbstractServiceClientFactory<TChannel> : ClientBase<TChannel> where TChannel : class
    {
        public TChannel Create(string url)
        {
            Endpoint.Address = new EndpointAddress(new Uri(url));
            return Channel;
        }
    }
}
