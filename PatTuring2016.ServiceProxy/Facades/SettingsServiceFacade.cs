//-----------------------------------------------------------------------
// <copyright file="SettingsServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.CommonProxy;

namespace PatTuring2016.ServiceProxy.Facades
{
    public class SettingsServiceFacade : BaseSettingsServiceFacade
    {
        private readonly SettingsServiceClientProxy _settingsClientProxy;
        private readonly BaseServiceFacade _baseServiceFacade;

        public SettingsServiceFacade(SettingsServiceClientProxy clientProxy, BaseServiceFacade baseServiceFacade)
        {
            _settingsClientProxy = clientProxy;
            _baseServiceFacade = baseServiceFacade;
        }

        public override MatchSettings GetSettings()
        {
            var request = new GetSettingsRequest { UserKey = _baseServiceFacade.UserKey };
            var response = _settingsClientProxy.GetSettings(request);
            return response.Settings;
        }

        public override SampleSettings GetSampleSettings()
        {
            var request = new GetSampleSettingsRequest { UserKey = _baseServiceFacade.UserKey };
            var response = _settingsClientProxy.GetSampleSettings(request);
            return response.Settings;
        }

        protected override void SetSampleFile(SampleFiles sampleFiles)
        {
            var settingsReturned = new SampleSettingsPresentation();

            var request = new ChangeSampleSettingsRequest
            {
                UserKey = _baseServiceFacade.UserKey,
                Settings = new SampleSettings { SampleFiles = sampleFiles }
            };
            var response = _settingsClientProxy.SetSampleSettings(request);
            settingsReturned.Settings = response.Settings;
            settingsReturned.SettingsChanged = response.Success;
        }

        protected override void SetSettings(MatchSettings settings)
        {
            var settingsReturned = new SettingsPresentation();

            var request = new ChangeSettingsRequest { UserKey = _baseServiceFacade.UserKey, Settings = settings };
            var response = _settingsClientProxy.SetSettings(request);
            settingsReturned.Settings = response.Settings;
            settingsReturned.SettingsChanged = response.Success;
        }
    }
}