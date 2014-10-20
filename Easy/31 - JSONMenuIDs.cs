using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace JsonMenuIDS
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (StreamReader sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var r = new Regex(@"(Label )\d+");
                    if (line != null)
                    {
                        int result = r.Matches(line).Cast<Match>().Sum(m => int.Parse(m.Value.Split(' ')[1]));
                        Console.WriteLine(result);
                    }
                }
        }
    }
}