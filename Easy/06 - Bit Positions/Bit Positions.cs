using System;
using System.Collections.Generic;
using System.IO;

namespace Bit_Positons
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(args[0]);
            var lines = new List<string>();
            var separator = new[] { ',' };

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
            }

            foreach (string t in lines)
            {
                var numbers = t.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                var number = Convert.ToInt32(numbers[0]);
                var firstPosition = Convert.ToInt32(numbers[1]) - 1;
                var secondPosition = Convert.ToInt32(numbers[2]) - 1;

                var binaryNumber = Convert.ToString(number, 2);
                var reversedBinaryNumber = "";

                for (var j = binaryNumber.Length - 1; j >= 0; j--)
                {
                    reversedBinaryNumber += binaryNumber[j];
                }

                Console.WriteLine(reversedBinaryNumber[firstPosition] == reversedBinaryNumber[secondPosition]
                    ? "true"
                    : "false");
            }
        }
    }
}