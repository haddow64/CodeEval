using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Remove_Characters
{
    internal static class RemoveCharacters
    {
        public static void Main(string[] args)
        {
            foreach (var text in from line in File.ReadAllLines(args[0])
                select line.Split(',') into split let pattern = "[" + split[1].Trim() + "]"
                select Regex.Replace(split[0], pattern, string.Empty).Trim())
            {
                Console.WriteLine(text);
            }
        }
    }
}