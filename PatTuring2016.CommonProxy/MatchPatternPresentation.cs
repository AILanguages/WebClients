//-----------------------------------------------------------------------
// <copyright file="MatchPatternPresentation.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.CommonProxy
{
    public class MatchPatternPresentation
    {
        public string MatchId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool MatchesSuccessfullyFound { get; set; }
        public Match Edit { get; set; }
        public string MenuType { get; set; }
        public string Message { get; set; }
    }
}
