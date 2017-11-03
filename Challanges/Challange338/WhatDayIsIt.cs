using System;

namespace Challange338
{
    public class WhatDayIsIt
    {
        public string NameOfDay(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
    }
}