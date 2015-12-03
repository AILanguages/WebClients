//-----------------------------------------------------------------------
// <copyright file="BaseServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ServiceProxy.Facades
{
    using DataContracts;
    using System;
    using System.Web;

    public class BaseServiceFacade
    {
        public string UserKey { get; private set; }

        public BaseServiceFacade(SessionService sessionService)
        {
            // session gone, major problem!
            if (HttpContext.Current.Session != null)
            {
                UserKey = Convert.ToString(HttpContext.Current.Session["UserKey"]);
            }

            // ensure valid link to server in place - create a new user key!
            var request = new GetIDRequest { UserKey = UserKey };
            var response = sessionService.GetID(request);

            if (!response.Success) return;

            if (string.IsNullOrWhiteSpace(UserKey))
            {
                UserKey = response.UserKey;
            }

            if (HttpContext.Current.Session != null)
            {
                HttpContext.Current.Session["UserKey"] = response.UserKey;
            }
        }
    }
}