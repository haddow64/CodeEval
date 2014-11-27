using System;
using System.Collections.Generic;
using System.IO;

namespace Swap_Elements
{
    class Program
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

            foreach (var s in lines)
            {
                var splitLine = s.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var numbers = splitLine[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                splitLine[1].Replace(" ", "");
                var swapElements = splitLine[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var t in swapElements)
                {
                    var indexes = t.Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                    var firstIndex = Convert.ToInt32(indexes[0]);
                    var secondIndex = Convert.ToInt32(indexes[1]);

                    var temp = numbers[firstIndex];
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = temp;
                }

                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}