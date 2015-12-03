//-----------------------------------------------------------------------
// <copyright file="SamplesServiceClientProxy.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.ServiceProxy
{
    using System.ServiceModel;
    using Contracts;
    using DataContracts;

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