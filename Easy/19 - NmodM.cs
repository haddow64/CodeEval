using System;
using System.IO;

namespace NmodM
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line)) continue;
                    var values = line.Split(',');
                    var n = Convert.ToInt32(values[0]);
                    var m = Convert.ToInt32(values[1]);
                    var i = 0;
                    while (n - (i*m) >= m)
                    {
                        i++;
                    }
                    Console.WriteLine(n - i*m);
                }
            Console.ReadLine();
        }
    }
}