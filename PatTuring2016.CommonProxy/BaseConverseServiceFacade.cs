//-----------------------------------------------------------------------
// <copyright file="BaseConverseServiceFacade.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;

namespace PatTuring2016.CommonProxy
{
    public abstract class BaseConverseServiceFacade
    {
        protected readonly IConverseService ConverseService;

        protected BaseConverseServiceFacade(IConverseService converseService)
        {
            ConverseService = converseService;
        }
    }
}