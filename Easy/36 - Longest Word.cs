using System;
using System.IO;
using System.Linq;

namespace Longest_Word
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
                        var temp = line.Split(' ');
                        string[] result = {string.Empty};
                        foreach (var t in temp.Where(t => t.Length > result[0].Length))
                        {
                            result[0] = t;
                        }
                        Console.WriteLine(result[0]);
                    }
                }
        }
    }
}