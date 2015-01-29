using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Longest_Lines
{
    static class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>();

            using (var sr = new StreamReader(args[0]))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        line.Trim(new char[] { '\r', ' ', '\t' });
                        lines.Add(line);
                    }
                    line = sr.ReadLine();
                }
            }

            int numberOfResults = Convert.ToInt32(lines[0]);

            IEnumerable<string> results = lines.OrderByDescending(result => result.Length);

            for (int i = 0; i < numberOfResults; i++)
            {
                Console.WriteLine(results.ElementAt(i));
            }
        }
    }
}