//-----------------------------------------------------------------------
// <copyright file="TranslateViewModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatTuring2016.Common.ScreenModels
{
    public class TranslateViewModel
    {
        public TranslateViewModel()
        {
            Reset();
        }

        private void Reset()
        {
            Translations = new List<TranslatePair>();
        }

        [Display(Name = "Translate source")]
        public string LastSearch { get; set; }

        public Match Match { get; set; }

        public MatchSettings MatchSettings { get; set; }
        public SampleSettings SampleSettings { get; set; }

        public List<TranslatePair> Translations { get; set; }
    }
}