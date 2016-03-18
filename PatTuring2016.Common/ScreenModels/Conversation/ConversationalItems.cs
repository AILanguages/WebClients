//-----------------------------------------------------------------------
// <copyright file="ConversationalItems.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace PatTuring2016.Common.ScreenModels.Conversation
{
    public static class ConversationalItems
    {
        internal static string GetCurrentTime()
        {
            var time = DateTime.Now;
            return time.ToString("HH:mm d MMM");
        }
    }
}
