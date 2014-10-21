using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordToDigit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var dic = new Dictionary<string, string>
                    {
                        {"zero", "0"},
                        {"one", "1"},
                        {"two", "2"},
                        {"three", "3"},
                        {"four", "4"},
                        {"five", "5"},
                        {"six", "6"},
                        {"seven", "7"},
                        {"eight", "8"},
                        {"nine", "9"}
                    };
                    var sb = new StringBuilder();
                    if (line != null) line.Split(';').ToList().ForEach(x => sb.Append(dic[x]));
                    Console.WriteLine(sb.ToString());
                }
        }
    }
}