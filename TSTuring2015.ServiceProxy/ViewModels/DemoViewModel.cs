//-----------------------------------------------------------------------
// <copyright file="DemoViewModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ServiceProxy.ViewModels
{
    using ScreenModels;

    public class DemoViewModel
    {
        public Match Match { get; set; }
        public MatchSettings Settings { get; set; }
        public SampleSettings SampleSettings { get; set; }
    }
}