//-----------------------------------------------------------------------
// <copyright file="HighTrackingData.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace PatTuring2016.Common.ScreenModels.Conversation
{
    public class HighTrackingData
    {
        public HighTrackingData()
        {
            HighContextList=new List<HighContext>();
        }

        public List<HighContext> HighContextList { get; set; }
    }
}