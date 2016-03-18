//-----------------------------------------------------------------------
// <copyright file="Politeness.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;

namespace PatTuring2016.Common
{
    public class AllPoliteList
    {
        public static Politeness[] GetArray()
        {
            return (Politeness[])Enum.GetValues(typeof(Politeness));
        }

        public static object[] FormalObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }
    public enum Politeness
    {
        VeryHigh,
        High,
        Neutral,
        Low
    }
}