using System;
using System.Collections.Generic;
using System.IO;

namespace PenultimateWord
{
    internal class PenultimateWord
    {
        private static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();
            var separator = new[] {' ', ',', '.', '!', '?'};

            using (sr)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            foreach (string s in lines)
            {
                string[] separatedWords = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                Array.Reverse(separatedWords);

                Console.WriteLine(separatedWords[1]);
            }
        }
    }
}