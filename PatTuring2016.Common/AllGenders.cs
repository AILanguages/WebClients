//-----------------------------------------------------------------------
// <copyright file="AllGenders.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;

namespace PatTuring2016.Common
{
    public class AllGenders
    {
        public static AllGendersList[] GetArray()
        {
            return (AllGendersList[])Enum.GetValues(typeof(AllGendersList));
        }

        public static object[] GenderObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum AllGendersList
    {
        Male,
        Female, 
        Neuter
    }
}