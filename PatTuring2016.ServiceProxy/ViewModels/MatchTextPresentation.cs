//-----------------------------------------------------------------------
// <copyright file="MatchTextPresentation.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.ServiceProxy.ViewModels
{
    public class MatchTextPresentation
    {
        public bool TextToUseFound { get; set; }
        public Match Match { get; set; }
        public bool EditFound { get; set; }
    }
}
