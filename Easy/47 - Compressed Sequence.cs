using System;
using System.IO;

namespace Compressed_Sequence
{
    internal static class CompressedSequence
    {
        public static void Main(string[] args)
        {
            using (var sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (null == line)
                        continue;

                    var vals = line.Trim().Split();
                    var count = 0;
                    var c = vals[0];
                    foreach (var i in vals)
                    {
                        if (i == c)
                            count += 1;
                        else
                        {
                            Console.Write(count + " " + c + " ");
                            count = 1;
                            c = i;
                        }
                    }
                    Console.WriteLine(count + " " + c);
                }
            }
        }
    }
}