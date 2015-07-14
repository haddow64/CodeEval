using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data_Recovery
{
    internal static class DataRecovery
    {
        private static int find_missing(IEnumerable<int> indices, int length)
        {
            var sum = indices.Sum();
            var expectedSum = length*(length + 1)/2;
            return expectedSum - sum;
        }

        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    var inputs = line.Trim().Split(';');
                    var words = inputs[0].Split();
                    var indices = inputs[1].Split().Select(x => int.Parse(x)).ToList();
                    indices.Add(find_missing(indices, words.Length));
                    for (var i = 1; i < indices.Count + 1; i++)
                        Console.Write(words[indices.IndexOf(i)] + " ");
                    Console.WriteLine();
                }
            }
        }
    }
}