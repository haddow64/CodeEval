using System;
using System.Collections.Generic;
using System.IO;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
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

            foreach (var t in lines)
            {
                var number = Convert.ToInt32(t);
                Console.WriteLine(Fibonacci(number));
            }
        }

        static long Fibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}