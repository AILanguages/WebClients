//-----------------------------------------------------------------------
// <copyright file="TrackingData.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace PatTuring2016.Common.ScreenModels.Conversation
{
    public class TrackingData
    {
        public TrackingData()
        {
            SpokenList=new List<Dialog>();
        }

        public List<Dialog> SpokenList { get; set; }
    }
}