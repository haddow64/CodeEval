using System;
using System.IO;
using System.Linq;

namespace BeautifulStrings
{
    public class BeautifulStrings
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1) return;

            using (var reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null) continue;

                    Console.WriteLine(GetBeauty(line));
                }
        }

        public static int GetBeauty(string text)
        {
            text = text.ToLower();
            var weights = Enumerable.Range(1, 26).Select(x => 0).ToArray();
            foreach (var index in text.Select(c => c - 'a').Where(index => index >= 0 && index <= 25))
            {
                weights[index]++;
            }

            var rank = 26;
            return weights
                .OrderByDescending(x => x)
                .Select(x => x * rank--)
                .Sum(x => x);
        }
    }
}