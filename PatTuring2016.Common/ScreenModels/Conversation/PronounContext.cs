//-----------------------------------------------------------------------
// <copyright file="PronounContext.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace PatTuring2016.Common.ScreenModels.Conversation
{
    public class PronounContext
    {
        public List<string> ClausePart { get; set; }
        public List<string> ClauseElements { get; set; }
        public string LS { get; set; }
        public string Clause { get; set; }
        public List<string> Information { get; set; }
    }
}