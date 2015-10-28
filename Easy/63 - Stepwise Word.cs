using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StepwiseWord
{
    static class StepwiseWordSolution
    {
        private static void Main(string[] args)
        {
            if (args[0] == string.Empty) return;

            foreach (var singleLine in File.ReadAllLines(args[0]).ToList())
            {
                Console.WriteLine(string.Join(" ", LongestWord(singleLine.Split(' ')).Select((t, i) => new string('*', i) + t).ToList()));
            }
        }

        private static IEnumerable<char> LongestWord(string[] words)
        {
            var longestWord = "";

            for (var i = 0; i < words.Length; i++)
            {
                if (i == 0)
                {
                    longestWord = words[0];
                }
                else
                {
                    if (words[i].Length > longestWord.Length) longestWord = words[i];
                }
            }

            return longestWord.ToCharArray();
        }
    }
}