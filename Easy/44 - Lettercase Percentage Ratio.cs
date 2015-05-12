using System;
using System.Collections.Generic;
using System.IO;

namespace LettercaseRercentageRatio
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();
            var results = new List<string>();
            int lowerCaseCount = 0, upperCaseCount = 0;

            using (sr)
            {
                var line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            for (var i = 0; i < lines.Count; i++)
            {
                var textFromLine = lines[i];

                for (var j = 0; j < textFromLine.Length; j++)
                {
                    if (Char.IsLower(textFromLine[j]))
                        lowerCaseCount++;
                    else if (Char.IsUpper(textFromLine[j]))
                        upperCaseCount++;
                }

                var lowerPercent = ((100f*lowerCaseCount)/textFromLine.Length);
                var upperPercent = ((100f*upperCaseCount)/textFromLine.Length);

                var result = String.Format("lowercase: {0:0.00} uppercase: {1:0.00}", lowerPercent, upperPercent);
                results.Add(result);

                lowerCaseCount = 0;
                upperCaseCount = 0;
            }

            for (var i = 0; i < results.Count; i++)
            {
                var item = results[i];
                Console.WriteLine(item);
            }
        }
    }
}