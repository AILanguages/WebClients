//-----------------------------------------------------------------------
// <copyright file="DemoServiceClientProxy.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.CommonProxy
{
    public class SettingsServiceClientProxy : AbstractServiceClientFactory<ISettingsService>, ISettingsService
    {
        public ChangeSettingsResponse SetSettings(ChangeSettingsRequest request)
        {
            return Channel.SetSettings(request);
        }

        public GetSettingsResponse GetSettings(GetSettingsRequest request)
        {
            return Channel.GetSettings(request);
        }

        public ChangeSampleSettingsResponse SetSampleSettings(ChangeSampleSettingsRequest request)
        {
            return Channel.SetSampleSettings(request);
        }

        public GetSampleSettingsResponse GetSampleSettings(GetSampleSettingsRequest request)
        {
            return Channel.GetSampleSettings(request);
        }
    }
}