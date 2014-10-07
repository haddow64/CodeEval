using System;
using System.IO;
using System.Linq;

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (line != null)
                    {
                        var cases = int.Parse(line);
                        var result = false;
                        for (var i = 0; i < 100; i++)
                        {
                            cases = (int)cases.ToString().Select(x => Math.Pow(double.Parse(x.ToString()), 2)).Sum();
                            if (cases == 1)
                            {
                                result = true;
                                break;
                            }
                        }
                        Console.WriteLine(result ? 1 : 0);
                    }
                }
        }
    }
}