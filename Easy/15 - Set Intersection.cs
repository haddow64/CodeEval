using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SetIntersection
{
    static class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(args[0]);
            var lines = new List<string>();

            using (reader)
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
            }

            foreach (string t in lines)
            {
                var splitLine = t.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var firstNumbers = splitLine[0].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
                var secondNumbers = splitLine[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
                var result = new List<int>();

                result.AddRange(firstNumbers.Count > secondNumbers.Count
                    ? secondNumbers.Where(t1 => firstNumbers.Contains(t1))
                    : firstNumbers.Where(t1 => secondNumbers.Contains(t1)));

                if (result.Count != 0)
                {
                    if (result.Count != 1)
                    {
                        for (var l = 0; l < result.Count - 1; l++)
                        {
                            Console.Write(result[l] + ",");
                        }
                        Console.WriteLine(result[result.Count - 1]);
                    }
                    else
                    {
                        Console.WriteLine(result[0]);
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}