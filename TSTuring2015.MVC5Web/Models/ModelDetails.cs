//-----------------------------------------------------------------------
// <copyright file="ModelDetails.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.MVCWeb.Models
{
    public class ModelDetails
    {
        public ModelDetails(string title, int listnumber, int part)
        {
            Title = title;
            ListNumber = listnumber;
            Part = part;
        }

        public string Title { get; private set; }
        public int ListNumber { get; private set; }
        public int Part { get; private set; }
    }
}