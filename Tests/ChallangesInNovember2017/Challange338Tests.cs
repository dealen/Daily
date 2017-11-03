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
            var result = whatDayIsIt.NameOfDay(date);
            result.Should().Be("Monday");
        }

        [Fact]
        public void What_day_of_week_will_be_new_years_eve()
        {
            var newYearsEve = new DateTime(2017, 12, 31);
            var result = whatDayIsIt.NameOfDay(newYearsEve);
            result.ShouldBeEquivalentTo("Sunday");
        }
    }
}