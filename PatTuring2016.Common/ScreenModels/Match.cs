//-----------------------------------------------------------------------
// <copyright file="SampleMatchDisplay.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace PatTuring2016.Common.ScreenModels
{
    public class Match
    {
        [Required(ErrorMessage = "A sentence is required")]
        [Display(Name = "Text to match")]
        public string TextIn { get; set; }
    }
}