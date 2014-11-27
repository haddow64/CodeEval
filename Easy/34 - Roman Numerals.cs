using System;
using System.Collections.Generic;
using System.IO;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();
            var arabicDigits = new List<int>
            {
                1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000
            };
            var romanDigits = new List<string>
            {
                "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"
            };

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
                var result = "";

                while (number > 0)
                {
                    for (var j = arabicDigits.Count - 1; j >= 0; j--)
                    {
                        if ((number / arabicDigits[j]) >= 1)
                        {
                            number -= arabicDigits[j];
                            result += romanDigits[j];
                            break;
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}