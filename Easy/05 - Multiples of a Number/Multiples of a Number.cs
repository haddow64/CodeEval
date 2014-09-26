using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Multiples_of_a_Number
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


            foreach (var t in lines)
            {
                var numbersFromLine = t.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();

                var firstNumber = numbersFromLine[0];
                var secondNumber = numbersFromLine[1];
                var step = 2;
                var result = secondNumber * 2;

                if (firstNumber <= result)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    while (result < firstNumber)
                    {
                        result = secondNumber * step;
                        step++;
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}