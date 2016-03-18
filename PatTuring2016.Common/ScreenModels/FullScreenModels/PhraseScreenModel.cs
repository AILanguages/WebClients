//-----------------------------------------------------------------------
// <copyright file="PhraseScreenModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using PatTuring2016.Common.ScreenModels.PartDisplays;

namespace PatTuring2016.Common.ScreenModels.FullScreenModels
{
    public class PhraseScreenModel : FullScreenModel
    {
        public PhraseScreenModel()
        {
            Top = new TopScreenModel();
            PhraseList = new List<AbstractPartDisplay>();
        }

        public TopScreenModel Top { get; set; }
        public List<AbstractPartDisplay> PhraseList { get; set; }
    }
}