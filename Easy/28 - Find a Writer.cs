using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FindAWriter
{
    internal class FindAWriter
    {
        private static void Main(string[] args)
        {
            using (StreamReader sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split('|');

                    split[1] = split[1].Trim();
                    int[] numbers = split[1].Split(' ').Select(int.Parse).ToArray();

                    var sb = new StringBuilder();
                    numbers.ToList().ForEach(x => sb.Append(split[0][x - 1]));

                    Console.WriteLine(sb.ToString());
                }
        }
    }
}