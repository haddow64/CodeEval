using System;
using System.Collections.Generic;
using System.IO;

namespace EvenNumber
{
    internal static class Program
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

            foreach (string s in lines)
            {
                int number = Convert.ToInt32(s);

                Console.WriteLine((number%2) == 0 ? "1" : "0");
            }
        }
    }
}