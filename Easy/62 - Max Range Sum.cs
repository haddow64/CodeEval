using System;
using System.IO;
using System.Linq;

namespace MaxRangeSum
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (var sr = File.OpenText(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    var readLine = sr.ReadLine();

                    if (readLine != null)
                    {
                        var data = readLine.Split(';');

                        var days = int.Parse(data[0]);
                        var movement = data[1].Split(null).Select(int.Parse).ToArray();

                        var max = 0;

                        for (var i = 0; i <= movement.Count() - days; i++)
                        {
                            var sum = 0;

                            for (var x = 0; x < days; x++)
                            {
                                sum += movement[i + x];
                            }

                            if (sum > max)
                                max = sum;
                        }

                        Console.WriteLine(max);
                    }
                }
            }
        }
    }
}
