//-----------------------------------------------------------------------
// <copyright file="ISamplesService.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ServiceModel;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.Common.Contracts
{
    [ServiceContract(Namespace = "http://demo.pat.ai/")]
    public interface ISamplesService
    {
        //samples
        [OperationContract]
        SampleMatchResponse GetHomePageView(SampleMatchRequest request);

        [OperationContract]
        ChooseSampleFileResponse ChooseSampleFileFor(ChooseSampleFileRequest request);

        [OperationContract]
        ChangeScreenResponse SelectSampleFor(ChangeScreenRequest request);

        [OperationContract]
        ChangeScreenResponse EditSampleFor(ChangeScreenRequest request);
    }
}