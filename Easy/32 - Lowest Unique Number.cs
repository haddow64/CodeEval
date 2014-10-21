using System;
using System.IO;
using System.Linq;

namespace LowestUniqueNumber
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    var readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        var numbers = readLine.Split(' ').Select(int.Parse).ToList();
                        var n = new int[10];
                        foreach (var i in numbers)
                            n[i]++;
                        var result = int.MaxValue;
                        var max = int.MaxValue;
                        for (var i = n.Length - 1; i > 0; i--)
                        {
                            if (n[i] == 1 && n[i] < max)
                            {
                                max = i;
                                result = numbers.IndexOf(max) + 1;
                            }
                        }
                        Console.WriteLine(result == int.MaxValue ? 0 : result);
                    }
                }
            Console.ReadLine();
        }
    }
}