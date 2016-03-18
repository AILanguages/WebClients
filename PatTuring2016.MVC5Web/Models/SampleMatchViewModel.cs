//-----------------------------------------------------------------------
// <copyright file="SampleMatchViewModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.MVC5Web.Models
{
    public class SampleMatchViewModel
    {
        public MatchSettings Settings { get; set; }
        public SampleSettings SampleSettings { get; set; }
        public SampleMatchDisplay SampleMatchDisplay { get; set; }
    }
}