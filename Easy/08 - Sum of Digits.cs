using System;
using System.IO;
using System.Linq;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine().Select(x => int.Parse(x.ToString())).Sum());
                }
            Console.ReadLine();
        }
    }
}