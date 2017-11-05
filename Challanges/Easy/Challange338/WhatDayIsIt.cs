using System;

namespace Challange338
{
    public class WhatDayIsIt
    {
        public string NameOfDayFromDateTimeObject(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }

        public string NameOfDayFromInteregesWithCalculationWithAlgorithm(int year, int month, int day)
        {            
            //https://en.wikipedia.org/wiki/Determination_of_the_day_of_the_week
            double d = day;
            double m = month;
            double Y = year;
            var y = m < 3 ? Y-- : Y; // 
            int result;
            // (y-2,23*m/9+d+4+y/4-y/100+y/400)%7
            result = (int)(y - (2.23 * m) / 9 + d + 4 + y / 4 - y / 100 + y / 400) % 7;

            return GetNameOfDay(result);
        }

        private string GetNameOfDay(int result)
        {
            switch (result)
            {
                case 0:
                    return "Monday";
                case 1:
                    return "Thusday";
                case 2:
                    return "Wednesday";
                case 3:
                    return "Thursday";
                case 4:
                    return "Friday";
                case 5:
                    return "Saturday";
                case 6:
                    return "Sunday";
                default:
                    return null;
            }
        }
    }
}
/*
Disparate variation[edit]
Another variation of the above algorithm likewise works with no lookup tables. A slight disadvantage is the unusual month and year counting convention. The formula is

{\displaystyle w=\left(d+\lfloor 2.6m-0.2\rfloor +y+\left\lfloor {\frac {y}{4}}\right\rfloor +\left\lfloor {\frac {c}{4}}\right\rfloor -2c\right){\bmod {7}},} w=\left(d+\lfloor 2.6m-0.2\rfloor +y+\left\lfloor {\frac {y}{4}}\right\rfloor +\left\lfloor {\frac {c}{4}}\right\rfloor -2c\right){\bmod {7}},
where

Y is the year minus 1 for January or February, and the year for any other month
y is the last 2 digits of Y
c is the first 2 digits of Y
d is the day of the month (1 to 31)
m is the shifted month (March=1,...,February=12)
w is the day of week (0=Sunday,...,6=Saturday). If w is negative you have to add 7 to it.
 */
