using System;
using System.IO;
using System.Text;

namespace Swap_Numbers
{
    internal static class SwapNumbers
    {
        public static void Main(string[] args)
        {
            foreach (var inputLines in File.ReadLines(args[0]))
            {
                var sb = new StringBuilder();
                foreach (var line in inputLines.Split(' '))
                {
                    sb.Append(line[line.Length - 1]).Append(line, 1, line.Length - 2).Append(line[0]).Append(' ');
                }
                Console.WriteLine(sb.ToString(0, sb.Length - 1));
            }
        }
    }
}