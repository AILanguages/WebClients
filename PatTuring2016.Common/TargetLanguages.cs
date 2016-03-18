//-----------------------------------------------------------------------
// <copyright file="TargetLanguages.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PatTuring2016.Common
{
    public static class TargetLanguage
    {
        public static string GetAttribute(this TargetLanguages targetLanguage)
        {
            return targetLanguage.ToString().ToLower() + "-*-";
        }
    }

    public enum TargetLanguages
    {
        English,
        German,
        French,
        Latin,
        Indonesian,
        Spanish,
        Portuguese,
        Italian,
        Japanese,
        Mandarin,
        Cantonese,
        AfricanEnglish,
        Korean
    }
}