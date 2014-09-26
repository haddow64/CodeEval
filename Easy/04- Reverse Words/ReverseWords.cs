using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader sr = File.OpenText(args[0]))
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(string.Join(" ", line.Split(' ').Reverse().ToArray<string>()));
            }
    }
}