using System;
using System.Collections.Generic;
using System.IO;

namespace HexToDec
{
    static class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();

            using (sr)
            {
                var line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            foreach (var item in lines)
            {
                var number = Convert.ToInt32(item, 16);
                Console.WriteLine(number);
            }
        }
    }
}