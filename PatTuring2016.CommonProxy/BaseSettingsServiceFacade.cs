//-----------------------------------------------------------------------
// <copyright file="BaseSettingsServiceFacade.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.CommonProxy
{
    public abstract class BaseSettingsServiceFacade
    {
        protected abstract void SetSampleFile(SampleFiles sampleFiles);
        protected abstract void SetSettings(MatchSettings settings);
        public abstract MatchSettings GetSettings();
        public abstract SampleSettings GetSampleSettings();

        public void UpdateSettings(MatchSettings matchSettings, SampleSettings sampleSettings)
        {
            // get settings from server to compare with new ones - avoid loss
            var oldsettings = GetSettings();
            var oldSamples = GetSampleSettings();

            if (matchSettings != null)
            {
                oldsettings.TargetLanguage = matchSettings.TargetLanguage;

                oldsettings.Speaker = matchSettings.Speaker;
                oldsettings.Characters = matchSettings.Characters;
                oldsettings.Formal = matchSettings.Formal;
                oldsettings.Polite = matchSettings.Polite;
                oldsettings.IllocutionaryForce = matchSettings.IllocutionaryForce;
                oldsettings.PersonChange = matchSettings.PersonChange;

                oldsettings.ShowSentences = matchSettings.ShowSentences;
                oldsettings.SimpleView = matchSettings.SimpleView;
            }

            if (sampleSettings != null)
            {
                oldSamples.SampleFiles = sampleSettings.SampleFiles;
            }

            SetSettings(oldsettings);
            SetSampleFile(oldSamples.SampleFiles);
        }
    }
}