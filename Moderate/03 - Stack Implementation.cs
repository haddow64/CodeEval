using System;
using System.IO;
using System.Text;

namespace Stack_Implementation
{
    static class StackImplementation
    {
        public static void Main(string[] args)
        {

            foreach (var inputLine in File.ReadAllLines(args[0]))
            {
                var sb = new StringBuilder();

                for (var i = inputLine.Split(' ').Length - 1; i >= 0; i -= 2)
                    sb.AppendFormat("{0} ", inputLine.Split(' ')[i]);

                Console.WriteLine(sb.ToString(0, sb.Length - 1));
            }
        }
    }
}