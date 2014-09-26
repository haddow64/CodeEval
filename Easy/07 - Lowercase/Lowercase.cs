using System;
using System.Collections.Generic;
using System.IO;

namespace Lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>();
            using (var sr = new StreamReader(args[0]))
            {
                using (sr)
                {
                    var line = sr.ReadLine();
                    while (line != null)
                    {
                        lines.Add(line);
                        line = sr.ReadLine();
                    }
                }
            }
            foreach (var item in lines)
            {
                Console.WriteLine(item.ToLower());
            }
        }
    }
}