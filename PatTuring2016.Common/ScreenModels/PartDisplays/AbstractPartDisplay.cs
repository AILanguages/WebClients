//-----------------------------------------------------------------------
// <copyright file="AbstractPartDisplay.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PatTuring2016.Common.ScreenModels.PartDisplays
{
    public class AbstractPartDisplay
    {
        public int Selection { get; set; }

        public int ListNumber { get; set; }
        public int Part { get; set; }

        public int Count { get; set; }
        public string Title { get; set; }
        public string Matches { get; set; }

        public int PhraseLength { get; set; }
        public string PhraseName { get; set; }
    }
}