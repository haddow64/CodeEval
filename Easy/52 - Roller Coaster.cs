using System;
using System.Collections.Generic;
using System.IO;

namespace Roller_Coaster
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            List<string> results = new List<string>();

            using (var sr = new StreamReader(args[0]))
            {
                using (sr)
                {
                    var line = sr.ReadLine();

                    while (line != null)
                    {
                        lines.Add(line);
                        line = sr.ReadLine();
                    }
                }
            }

            for (var i = 0; i < lines.Count; i++)
            {
                results.Add(ConvertLine(lines[i]));
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static string ConvertLine(string line)
        {
            var index = 0;
            var result = "";

            foreach (var c in line)
            {
                if (char.IsLetter(c))
                {
                    result += index%2 == 0 ? c.ToString().ToUpper() : c.ToString().ToLower();
                    index++;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}