using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Delta_Time
{
    static class DeltaTime
    {
        static void Main(string[] args)
        {
            foreach (var time in GetDeltaTime(File.ReadLines(args[0]).ToList()))
            {
                Console.WriteLine(time);
            }

        }

        private static IEnumerable<TimeSpan> GetDeltaTime(List<string> inputLines)
        {
            var findDeltaTime = new List<TimeSpan>();

            foreach (var line in inputLines)
            {
                var times = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var firstTime = DateTime.Parse(times[0]);
                var secondTime = DateTime.Parse(times[1]);

                var diff = secondTime.Subtract(firstTime);

                if (diff.Hours < 0 || diff.Minutes < 0 || diff.Seconds < 0)
                {
                    diff = diff.Negate();
                }

                findDeltaTime.Add(diff);
            }
            return findDeltaTime;
        }
    }
}
