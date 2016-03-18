//-----------------------------------------------------------------------
// <copyright file="GetaMatch.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.CommonProxy
{
    public class GetaMatch
    {
        protected MatchPatternPresentation GetAMatchFor(Match match, NewMatchResponse response)
        {
            var matchPattern = new MatchPatternPresentation();

            if (response.Success)
            {
                matchPattern.MatchesSuccessfullyFound = true;
                matchPattern.MatchId = response.UserKey;
                matchPattern.ExpiryDate = response.ExpirationDate;
                matchPattern.MenuType = response.MenuType;
            }
            else
            {
                matchPattern.MatchesSuccessfullyFound = false;
                matchPattern.Message = response.Message;
                matchPattern.Edit = match;
            }

            return matchPattern;
        }
    }
}