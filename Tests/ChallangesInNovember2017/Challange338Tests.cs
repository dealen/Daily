using Xunit;
using System;
using Challange338;
using FluentAssertions;

namespace Tests.ChallangesInNovemner2017
{
    public class Challange338Tests
    {
        private WhatDayIsIt whatDayIsIt = new WhatDayIsIt();

        [Fact]
        public void What_day_was_on_my_birthday()
        {
            var date = new DateTime(1988, 06, 06);
            var result = whatDayIsIt.NameOfDayFromDateTimeObject(date);
            result.Should().Be("Monday");
        }

        [Fact]
        public void What_day_of_week_will_be_new_years_eve()
        {
            var newYearsEve = new DateTime(2017, 12, 31);
            var result = whatDayIsIt.NameOfDayFromDateTimeObject(newYearsEve);
            result.ShouldBeEquivalentTo("Sunday");
        }

        [Fact]
        public void What_day_of_week_will_be_my_next_birthday()
        {
            var myNextBirthdayYear = 2018;
            var myNextBirthdayMonth = 6;
            var myNextBirthdayDay = 6;
            var result = whatDayIsIt.NameOfDayFromInteregesWithCalculationWithAlgorithm(myNextBirthdayYear, myNextBirthdayMonth, myNextBirthdayDay);
            result.ShouldBeEquivalentTo("Wednesday");
        }

        [Fact]
        public void What_day_of_wee_landing_on_moon_took_place()
        {
            var landingYear = 1969;
            var landingMonth = 6;
            var landingDay = 24;
            var result = whatDayIsIt.NameOfDayFromInteregesWithCalculationWithAlgorithm(landingYear, landingMonth, landingDay);
            result.ShouldBeEquivalentTo("Thusday");
        }
    }
}