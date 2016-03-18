//-----------------------------------------------------------------------
// <copyright file="StandardScreenModel.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using PatTuring2016.Common.ScreenModels.PartDisplays;

namespace PatTuring2016.Common.ScreenModels.FullScreenModels
{
    public class StandardScreenModel : FullScreenModel
    {
        public StandardScreenModel()
        {
            Top = new TopScreenModel();
            Main = new List<SenseListModel>();
            MainList = new List<AbstractPartDisplay>();
        }

        public TopScreenModel Top { get; set; }
        public List<SenseListModel> Main { get; set; }
        public List<AbstractPartDisplay> MainList { get; set; }
    }
}