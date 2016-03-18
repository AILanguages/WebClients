//-----------------------------------------------------------------------
// <copyright file="WordScreenModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PatTuring2016.Common.ScreenModels.FullScreenModels
{
    public class WordScreenModel : FullScreenModel
    {
        public WordScreenModel()
        {
            CssScreen = "Word";
            ScreenName = "Word";
        }

        public string WordDetails { get; set; }
        public string WordForms { get; set; }
        public string Attributes { get; set; }
        public string Grammars { get; set; }
        public string Senses { get; set; }
    }
}