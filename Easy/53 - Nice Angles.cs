using System;
using System.IO;
using System.Linq;

namespace Nice_Angles
{
    static class Program
    {
        static void Main(string[] args)
        {
            foreach (var line in File.ReadLines(args[0]).ToList())
            {
                Console.WriteLine(ConvertDms(double.Parse(line)));
            }
        }

        private static string ConvertDms(double line)
        {
            var degrees = Convert.ToInt32(Math.Floor(line));
            var minutes = Convert.ToInt32(Math.Floor((line - degrees) * 60));
            var seconds = Convert.ToInt32(Math.Floor((line - degrees - (minutes / 60d)) * 3600));

            return string.Format("{0}.{1:D2}'{2:D2}\"", degrees, minutes, seconds);
        }
    }
}