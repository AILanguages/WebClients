//-----------------------------------------------------------------------
// <copyright file="SettingsPresentation.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.CommonProxy
{
    public class SettingsPresentation
    {
        public MatchSettings Settings { get; set; }
        public bool SettingsChanged { get; set; }
    }
}
