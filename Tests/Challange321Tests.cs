using Xunit;
using System;
using Challange321;
using FluentAssertions;

namespace Tests
{    
    public class Challange321Tests
    {
        private TranslateClock translateClock = new TranslateClock();

        [Fact]
        public void Can_translate_current_time_into_words()
        {
            var currentTime = DateTime.UtcNow;
            var result = translateClock.GetTimeInWords($"{currentTime.Hour}:{currentTime.Minute.ToString("0,2:D2")}");
            result.Should().NotBeNullOrEmpty();
        }    

        [Fact]
        public void Can_translate_clock_translate_custom_time()
        {
            var customTime = "04:11";
            var result = translateClock.GetTimeInWords(customTime);
            result.Should().Be("It's Four Eleven am");
            customTime = "14:26";
            result = translateClock.GetTimeInWords(customTime);
            result.Should().Be("It's Two Twenty Six pm");
        }   
    }
}