using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace First_Non_Repeated_Char
{
    static class Program
    {
        private static char _firstCharacter = '\0';
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(args[0]);
            List<string> lines = new List<string>();
            List<char> results = new List<char>();

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
            }

            int length = lines.Count;

            for (int i = 0; i < length; i++)
            {
                _firstCharacter = FirstChar(lines[i]);
                results.Add(_firstCharacter);
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static char FirstChar(string line)
        {
            int length = line.Length;

            for (int i = 0; i < length; i++)
            {
                var count = line.Count(x => x == line[i]);
                if (count == 1)
                {
                    _firstCharacter = line[i];
                    break;
                }
            }

            return _firstCharacter;
        }
    }
}