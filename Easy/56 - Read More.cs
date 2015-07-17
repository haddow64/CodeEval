using System;
using System.IO;
using System.Linq;

namespace Read_More
{
    static class ReadMore
    {
        static void Main(string[] args)
        {
            if (args[0] != string.Empty)
            {
                foreach (var singleLine in File.ReadLines(args[0]).ToList().Where(singleLine => singleLine != string.Empty))
                {
                    Console.WriteLine(singleLine.Length <= 55 ? singleLine : GetShortenedString(singleLine) + "... <Read More>");
                }
            }
        }

        private static string GetShortenedString(string singleLine)
        {
            var trimLine = singleLine.Substring(0, 40);
            if (!trimLine.Contains(" ")) return trimLine;

            var array = trimLine.Split(' ').ToList();
            array.RemoveAt(array.Count - 1);
            return array.Count() > 1 ? string.Join(" ", array) : string.Join("", array);
        }
    }
}
