//-----------------------------------------------------------------------
// <copyright file="DemoViewModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.ServiceProxy.ViewModels
{

    public class DemoViewModel
    {
        public Match Match { get; set; }
        public MatchSettings Settings { get; set; }
        public SampleSettings SampleSettings { get; set; }
    }
}