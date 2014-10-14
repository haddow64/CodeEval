using System;
using System.Collections.Generic;
using System.IO;

namespace CapitalizeWords
{
    internal class CapitalizeWords
    {
        private static void Main(string[] args)
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

            char[] separator = {' '};

            foreach (string item in lines)
            {
                string[] words = item.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(word[j].ToString().ToUpper());
                        }
                        else
                        {
                            Console.Write(word[j]);
                        }
                    }
                    Console.Write(" ");
                    if (i == words.Length - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}