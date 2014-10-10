using System;
using System.Collections.Generic;
using System.IO;

namespace ArmstrongNumber
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

            foreach (var s in lines)
            {
                var number = Convert.ToInt32(s);
                var loop = number;
                var length = s.Length;
                var result = 0;

                while (loop > 0)
                {
                    var temp = loop % 10;
                    loop /= 10;
                    result += (int)Math.Pow(temp, length);
                }
                Console.WriteLine(result == number ? "True" : "False");
            }
        }
    }
}