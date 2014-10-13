using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SimpleSorting
{
    internal static class SimpleSorting
    {
        private static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();
            var numbers = new List<double>();
            var separator = new[] {' '};

            using (sr)
            {
                var line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            foreach (var numbersFromLine in lines.Select(s => s.Split(separator, StringSplitOptions.RemoveEmptyEntries)))
            {
                numbers.AddRange(numbersFromLine.Select(t => Convert.ToDouble(t, CultureInfo.InvariantCulture.NumberFormat)));

                numbers.Sort();

                foreach (var number in numbers)
                {
                    Console.Write("{0:F3} ", number);
                }
                Console.WriteLine();
                numbers = new List<double>();
            }
        }
    }
}