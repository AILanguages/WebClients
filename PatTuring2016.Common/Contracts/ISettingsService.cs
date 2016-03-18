//-----------------------------------------------------------------------
// <copyright file="ISettingsService.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ServiceModel;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.Common.Contracts
{
    [ServiceContract(Namespace = "http://demo.pat.ai/")]
    public interface ISettingsService
    {
        [OperationContract]
        ChangeSettingsResponse SetSettings(ChangeSettingsRequest request);

        [OperationContract]
        GetSettingsResponse GetSettings(GetSettingsRequest request);

        [OperationContract]
        ChangeSampleSettingsResponse SetSampleSettings(ChangeSampleSettingsRequest request);

        [OperationContract]
        GetSampleSettingsResponse GetSampleSettings(GetSampleSettingsRequest request);
    }
}