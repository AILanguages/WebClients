//-----------------------------------------------------------------------
// <copyright file="SamplesServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ServiceModel;
using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.ServiceProxy
{
    public class SamplesServiceClientProxy : ClientBase<ISamplesService>, ISamplesService
    {
        public SampleMatchResponse GetHomePageView(SampleMatchRequest request)
        {
            return Channel.GetHomePageView(request);
        }

        public ChooseSampleFileResponse ChooseSampleFileFor(ChooseSampleFileRequest request)
        {
            return Channel.ChooseSampleFileFor(request);
        }

        public ChangeScreenResponse SelectSampleFor(ChangeScreenRequest request)
        {
            return Channel.SelectSampleFor(request);
        }

        public ChangeScreenResponse EditSampleFor(ChangeScreenRequest request)
        {
            return Channel.EditSampleFor(request);
        }
    }
}