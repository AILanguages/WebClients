//-----------------------------------------------------------------------
// <copyright file="PersonChange.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;

namespace PatTuring2016.Common
{
    public class AllPersonChangeList
    {
        public static PersonChange[] GetArray()
        {
            return (PersonChange[])Enum.GetValues(typeof(PersonChange));
        }

        public static object[] PersonChangeObjectList()
        {
            return GetArray().Cast<object>().ToArray();
        }
    }

    public enum PersonChange
    {
        Source,
        OneToOne1PSg,
        OneToMany2PPl,
        WithMe1PPl
    }
}