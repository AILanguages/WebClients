//-----------------------------------------------------------------------
// <copyright file="SenseScreenModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PatTuring2016.Common.ScreenModels.FullScreenModels
{
    public class SenseScreenModel : FullScreenModel
    {      
        public SenseScreenModel()
        {
            ScreenName = "Sense";
            CssScreen = "Sense";
            Synonyms = string.Empty;
            Inflections = string.Empty;
        }

        public string SenseDetails { get; set; }
        public string SenseLabel { get; set; }
        public string Synonyms { get; set; }
        public string Inflections { get; set; }

        public int HypernymCount { get; set; }
        public int HyponymCount { get; set; }
        public int HolonymCount { get; set; }
        public int MeronymCount { get; set; }

        public int MembHoloCount { get; set; }
        public int MembMeroCount { get; set; }
        public int SubstHoloCount { get; set; }
        public int SubstMeroCount { get; set; }
        public int InstHyperCount { get; set; }
        public int InstHypoCount { get; set; }
        public int CausesCount { get; set; }
        public int CausedByCount { get; set; }
        public int EntailsCount { get; set; }
        public int EntailedByCount { get; set; }
    }
}