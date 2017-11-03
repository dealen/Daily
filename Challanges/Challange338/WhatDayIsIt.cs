using System;

namespace Challange338
{
    public class WhatDayIsIt
    {
        public string NameOfDayFromDateTimeObject(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }

        public string NameOfDayFromInteregesWithCalculation(int year, int month, int day)
        {
            return null;
        }
    }
}