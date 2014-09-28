using System;
using System.IO;

namespace SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            using (var sr = new StreamReader(args[0]))
            {
                var line = sr.ReadLine();

                while (line != null)
                {
                    sum += Convert.ToInt32(line);
                    line = sr.ReadLine();
                }
            }

            Console.WriteLine(sum);
        }
    }
}