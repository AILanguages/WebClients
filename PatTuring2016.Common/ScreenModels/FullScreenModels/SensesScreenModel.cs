//-----------------------------------------------------------------------
// <copyright file="SensesScreenModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using PatTuring2016.Common.ScreenModels.PartDisplays;

namespace PatTuring2016.Common.ScreenModels.FullScreenModels
{
    public class SensesScreenModel : FullScreenModel
    {
        public SensesScreenModel()
        {
            CssScreen = "Senses";
            ScreenName = "Senses";
            SenseList = new List<AbstractPartDisplay>();
        }

        public List<AbstractPartDisplay> SenseList { get; set; }
    }
}