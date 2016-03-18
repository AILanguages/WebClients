//-----------------------------------------------------------------------
// <copyright file="ConversationData.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PatTuring2016.Common.ScreenModels.Conversation
{
    public class ConversationData
    {
        public ConversationData()
        {
            CurrentResponse = null;
            TrackingData = new TrackingData();
            PronounTrackingData = new PronounTrackingData();
            HighTrackingData = new HighTrackingData();
            HighTrackingData.HighContextList.Add(
                new HighContext
            {
                Element = "When",
                Value = ConversationalItems.GetCurrentTime()
            });
        }

        public Dialog CurrentResponse { get; set; }
        public TrackingData TrackingData { get; set; }
        public PronounTrackingData PronounTrackingData { get; set; }
        public HighTrackingData HighTrackingData { get; set; }

        public void SayItBack(string speaker, string whatsaid, string whensaid)
        {
            if (string.IsNullOrWhiteSpace(whatsaid)) return;

            CurrentResponse = new Dialog { Speaker = speaker, WhatSaid = whatsaid, WhenSaid = whensaid };

            TrackingData.SpokenList.Add(new Dialog
            {
                Speaker = speaker,
                WhatSaid = whatsaid,
                WhenSaid = whensaid
            });
        }
    }
}