//-----------------------------------------------------------------------
// <copyright file="AllLanguages.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;

namespace PatTuring2016.Common
{
    public class AllLanguages
    {
        public static AllLanguageList[] GetArray()
        {
            return (AllLanguageList[])Enum.GetValues(typeof(AllLanguageList));
        }

        public static object[] LanguageObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum AllLanguageList
    {
        OzEnglish, 
        USEnglish,
        UKEnglish,
        German,
        Korean, 
        Italian,
        Japanese, 
        Spanish,
        Portuguese, 
        Indonesian, 
        French, 
        Mandarin, 
        Cantonese
    }
}