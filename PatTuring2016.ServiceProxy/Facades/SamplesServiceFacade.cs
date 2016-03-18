//-----------------------------------------------------------------------
// <copyright file="SamplesServiceFacade.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Web;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.ServiceProxy.ViewModels;

namespace PatTuring2016.ServiceProxy.Facades
{
    public class SamplesServiceFacade
    {
        private readonly SamplesServiceClientProxy _samplesClientProxy;
        private readonly BaseServiceFacade _baseServiceFacade;

        public SamplesServiceFacade(SamplesServiceClientProxy samplesService, BaseServiceFacade baseServiceFacade)
        {
            _samplesClientProxy = samplesService;
            _baseServiceFacade = baseServiceFacade;
        }

        public SampleMatchDisplay GetHomePageView()
        {
            var request = new SampleMatchRequest { UserKey = _baseServiceFacade.UserKey };

            var response = _samplesClientProxy.GetHomePageView(request);

            if (response.UserKey != _baseServiceFacade.UserKey)
            {
                HttpContext.Current.Session["UserKey"] = response.UserKey;
            }

            return response.SampleMatchDisplay;
        }

        public bool SelectSampleFor(int selection)
        {
            var screenReturned = new ChangePresentation();

            var request = new ChangeScreenRequest { UserKey = _baseServiceFacade.UserKey, Selection = selection };
            var response = _samplesClientProxy.SelectSampleFor(request);

            screenReturned.Screen = response.Screen;
            screenReturned.ScreenFound = response.Success;

            return screenReturned.ScreenFound;
        }

        public bool EditSampleFor(int selection)
        {
            var screenReturned = new ChangePresentation();

            var request = new ChangeScreenRequest { UserKey = _baseServiceFacade.UserKey, Selection = selection };
            var response = _samplesClientProxy.EditSampleFor(request);

            screenReturned.Screen = response.Screen;
            screenReturned.ScreenFound = response.Success;

            return screenReturned.ScreenFound;
        }

        public void ChooseSampleFileFor(int choice)
        {
            var request = new ChooseSampleFileRequest { UserKey = _baseServiceFacade.UserKey, Selection = choice };
            _samplesClientProxy.ChooseSampleFileFor(request);
        }
    }
}