using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Age_Distribution
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

            foreach (int age in lines.Select(s => Convert.ToInt32(s)))
            {
                if (0 <= age && age <= 2)
                    Console.WriteLine("Still in Mama's arms");
                else if (3 <= age && age <= 4)
                    Console.WriteLine("Preschool Maniac");
                else if (5 <= age && age <= 11)
                    Console.WriteLine("Elementary school");
                else if (12 <= age && age <= 14)
                    Console.WriteLine("Middle school");
                else if (15 <= age && age <= 18)
                    Console.WriteLine("High school");
                else if (19 <= age && age <= 22)
                    Console.WriteLine("College");
                else if (23 <= age && age <= 65)
                    Console.WriteLine("Working for the man");
                else if (66 <= age && age <= 100)
                    Console.WriteLine("The Golden Years");
                else
                    Console.WriteLine("This program is for humans");
            }
        }
    }
}