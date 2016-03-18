//-----------------------------------------------------------------------
// <copyright file="FullNounScreenModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels.PartDisplays;

namespace PatTuring2016.Common.ScreenModels.FullScreenModels
{
    public class FullNounScreenModel : FullClauseScreenModel
    {
        public FullNounScreenModel()
        {
            ScreenName = "Noun";
        }

        public SenseListModel Noun { get; set; }
        public SenseListModel Noun2 { get; set; }

        // NP level i.e. Clause        
        public SenseListModel Adjective { get; set; }
        public SenseListModel Adjective2 { get; set; }
        public SenseListModel Determiner { get; set; }
        public SenseListModel Deixis { get; set; }

        public SenseListModel Opinion { get; set; }
        public SenseListModel Size { get; set; }
        public SenseListModel Length { get; set; }
        public SenseListModel Age { get; set; }
        public SenseListModel Colour { get; set; }
        public SenseListModel Origin { get; set; }
        public SenseListModel Material { get; set; }

        //Core
        public SenseListModel Of { get; set; }
        public SenseListModel Negative { get; set; }
        public SenseListModel Quantifier { get; set; }

        public TextListPartDisplay NounNuclearOperators { get; set; }
        public TextListPartDisplay NounNuclearAttributes { get; set; }

        public TextListPartDisplay NounCoreAttributes { get; set; }
        public TextListPartDisplay NounCoreOperators { get; set; }

        public TextListPartDisplay NounPhraseAttributes { get; set; }
        public TextListPartDisplay NounPhraseOperators { get; set; }
    }
}