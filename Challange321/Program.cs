using System;
using System.Collections.Generic;

/* 
https://www.reddit.com/r/dailyprogrammer/comments/6jr76h/20170627_challenge_321_easy_talking_clock/
Description
No more hiding from your alarm clock! You've decided you want your computer to keep you updated on the time so you're never late again. A talking clock takes a 24-hour time and translates it into words.
Input Description
An hour (0-23) followed by a colon followed by the minute (0-59).
Output Description
The time in words, using 12-hour format followed by am or pm.
Sample Input data
    00:00
    01:30
    12:05
    14:01
    20:29
    21:00
Sample Output data
    It's twelve am
    It's one thirty am
    It's twelve oh five pm
    It's two oh one pm
    It's eight twenty nine pm
    It's nine pm
Extension challenges (optional)
Use the audio clips found here(http://steve-audio.net/voices/) to give your clock a voice.
 */
namespace Challange321
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TranslateClock
    {
        Dictionary<string, string> hoursDictionary = new Dictionary<string, string>{
            { "00", "Noon" }, { "01", "First" }, { "02", "Two" }, { "03", "Third" }, { "04", "Four" },
            { "05", "Five" }, { "06", "Six" }, { "07", "Seven" }, { "08", "Eight" }, { "09", "Nine" },
            { "10", "Ten" }, { "11", "Eleven" }, { "12", "Twelve" }, { "13", "First" }, { "14", "Two" },
            { "15", "Three" }, { "16", "Four" }, { "17", "Five" }, { "18", "Six" }, { "19", "Seven" },
            { "20", "Eight" }, { "21", "Nine" }, { "22", "Ten" }, { "23", "Eleven" }
        };

        Dictionary<int, string> minutesOneness = new Dictionary<int, string>{
            { 1, "One" }, { 2, "Two" }, { 3, "Three" }, { 4, "Four" }, { 5, "Five" },
            { 6, "Six" }, { 7, "Seven" }, { 8, "Eight" }, { 9, "Nine" }, { 0, "" },
        };

        Dictionary<int, string> minutesTens = new Dictionary<int, string>{
            { 0, "zero" }, { 1, "exception" }, { 2, "Twenty" }, { 3, "Thirteen" }, { 4, "Fourteen" }, { 5, "Fiveteen" }
        };

        Dictionary<int, string> minutesExc = new Dictionary<int, string>
        {
            { 10, "Ten" }, { 11, "Eleven" }, { 12, "Twelve" }, { 13, "Thirteen" }, { 14, "Fourteen" },
            { 15, "Fiveteen" }, { 16, "Sixteen" }, { 17, "Seventeen" }, { 18, "Eighteen" }, { 19, "Nineteen" }
        };

        public string GetTimeInWords(string time)
        {
            // 00:00
            // 01234
            var result = "";
            var hourResult = "";
            var minutesResult = "";

            var hour = time.Substring(0, 2);
            var minutesTens = time.Substring(3, 1);
            var minutesOneness = time.Substring(4, 1);

            var intMinute = 0;

            hourResult = hoursDictionary[hour];

            if (int.TryParse(minutesTens, out intMinute))
            {
                if (intMinute >= 10 && intMinute < 20)
                {
                    var minutes = int.Parse(time.Substring(3, 2));
                    minutesResult = minutesExc[minutes];
                }
                else 
                {


                }
            }

            return result;
        }
    }
}
