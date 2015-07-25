using System;
using System.IO;

namespace Decimal_To_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var line in File.ReadLines(args[0]))
            {
                Console.WriteLine(Convert.ToString(int.Parse(line), 2));
            }
        }
    }
}