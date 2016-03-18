//-----------------------------------------------------------------------
// <copyright file="SampleMatchDisplay.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace PatTuring2016.Common.ScreenModels
{
    public class SampleMatchDisplay
    {
        public string CurrentFile { get; set; }
        public string[] FileChoices { get; set; }
        public List<AnnotatedMatch> MatchList { get; set; }
        public string Description { get; set; }
    }
}