using System;
using System.IO;
using System.Linq;

namespace UniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(string.Join(",", sr.ReadLine().Split(',').Distinct().ToArray()));
                }
        }
    }
}
