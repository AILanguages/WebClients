//-----------------------------------------------------------------------
// <copyright file="Formality.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;

namespace PatTuring2016.Common
{
    public class AllFormalList
    {
        public static Formalities[] GetArray()
        {
            return (Formalities[])Enum.GetValues(typeof(Formalities));
        }

        public static object[] FormalObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum Formalities
    {
        VeryHigh,
        High,
        Neutral,
        Low
    }
}