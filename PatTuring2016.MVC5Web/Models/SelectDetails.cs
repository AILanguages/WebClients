﻿//-----------------------------------------------------------------------
// <copyright file="SelectDetails.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PatTuring2016.MVC5Web.Models
{
    public class SelectDetails
    {
        public SelectDetails(string title, int select)
        {
            Title = title;
            Select = select;
        }

        public string Title { get; private set; }
        public int Select { get; private set; }
    }
}