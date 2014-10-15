using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SwapCase
{
    internal class SwapCase
    {
        private static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();

            using (sr)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            foreach (var finalStrings in lines.Select(item => item.Select(n => char.IsLower(Convert.ToChar(n)) ? n.ToString().ToUpper() : n.ToString().ToLower())))
            {
                Console.WriteLine(string.Join("", finalStrings));
            }
        }
    }
}