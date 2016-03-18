//-----------------------------------------------------------------------
// <copyright file="TranslatePair.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace PatTuring2016.Common.ScreenModels
{
    public class TranslatePair
    {
        [Required(ErrorMessage = "A sentence is required")]
        [Display(Name = "Matched pair - source and target")]
        public string Source { get; set; }
        public string Target { get; set; }        
    }
}