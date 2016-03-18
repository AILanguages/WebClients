//-----------------------------------------------------------------------
// <copyright file="PronounTrackingData.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace PatTuring2016.Common.ScreenModels.Conversation
{
    public class PronounTrackingData
    {
        public PronounTrackingData()
        {
            PronounList=new List<PronounContext>();
        }

        public List<PronounContext> PronounList { get; set; }
    }
}