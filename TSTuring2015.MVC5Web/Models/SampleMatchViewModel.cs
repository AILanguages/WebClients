//-----------------------------------------------------------------------
// <copyright file="SampleMatchViewModel.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.MVCWeb.Models
{
    using ScreenModels;

    public class SampleMatchViewModel
    {
        public MatchSettings Settings { get; set; }
        public SampleSettings SampleSettings { get; set; }
        public SampleMatchDisplay SampleMatchDisplay { get; set; }
    }
}