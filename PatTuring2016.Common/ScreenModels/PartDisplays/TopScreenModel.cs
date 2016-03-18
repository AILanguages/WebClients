//-----------------------------------------------------------------------
// <copyright file="TopScreenModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels.PartDisplays;

namespace PatTuring2016.Common.ScreenModels.PartDisplays
{
    public class TopScreenModel 
    {
        public TextPartDisplay MatchedText { get; set; }
        public TextListPartDisplay Operators { get; set; }
        public TextListPartDisplay Attributes { get; set; }
        public TextPartDisplay PhraseName { get; set; }
    }
}