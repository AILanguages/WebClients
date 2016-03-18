//-----------------------------------------------------------------------
// <copyright file="ScreenPresentation.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels.FullScreenModels;

namespace PatTuring2016.CommonProxy
{
    public class ScreenPresentation
    {
        public FullScreenModel ScreenModel { get; set; }
        public string ScreenName { get; set; }
        public bool ScreenFound { get; set; }
        public bool SimpleView { get; set; }
    }
}
