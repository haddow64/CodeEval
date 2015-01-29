using System;
using System.IO;
using System.Linq;

namespace Split_The_Number
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    var readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] input = readLine.Split(' ');
                        if (input[1].Contains('+'))
                        {
                            string[] indices = input[1].Split('+');
                            long result = long.Parse(string.Join("", input[0].Take(indices[0].Length).Select(x => x.ToString()).ToArray())) + long.Parse(string.Join("", input[0].Skip(indices[0].Length).Take(indices[1].Length).Select(x => x.ToString()).ToArray()));
                            Console.WriteLine(result);
                        }
                        else
                        {
                            string[] indices = input[1].Split('-');
                            long result = long.Parse(string.Join("", input[0].Take(indices[0].Length).Select(x => x.ToString()).ToArray())) - long.Parse(string.Join("", input[0].Skip(indices[0].Length).Take(indices[1].Length).Select(x => x.ToString()).ToArray()));
                            Console.WriteLine(result);
                        }
                    }
                }
            Console.ReadLine();
        }
    }
}