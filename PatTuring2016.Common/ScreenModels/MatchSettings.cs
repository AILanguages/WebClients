//-----------------------------------------------------------------------
// <copyright file="MatchSettings.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PatTuring2016.Common.ScreenModels
{
    public class MatchSettings
    {
        public MatchSettings()
        {
            ShowSentences = false;
            SimpleView = true;
            TargetLanguage = TargetLanguages.English;
            Formal = Formalities.Neutral;
            Polite = Politeness.Neutral;
            Speaker = RelativePositions.WorkersToWorkers;
            IllocutionaryForce = IllocutionaryForce.Source;
            PersonChange = PersonChange.Source;
            Characters = Display.Letters;
        }

        public Match Edit { get; set; }
        public Match Last { get; set; }

        public TargetLanguages TargetLanguage { get; set; }
        public bool ShowSentences { get; set; }
        public bool SimpleView { get; set; }
        public Display Characters { get; set; }
        public Formalities Formal { get; set; }
        public Politeness Polite { get; set; }
        public RelativePositions Speaker { get; set; }
        public PersonChange PersonChange { get; set; }
        public IllocutionaryForce IllocutionaryForce { get; set; }
    }
}