using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Shortest_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (line != null)
                    {
                        var result = line.Length;
                        for (var i = 1; i <= line.Length; i++)
                        {
                            var temp = line.Substring(0, i);
                            var r = new Regex(temp);
                            if (r.Matches(line).Count * temp.Length == line.Length)
                            {
                                result = i;
                                break;
                            }
                        }
                        Console.WriteLine(result);
                    }
                }
        }
    }
}