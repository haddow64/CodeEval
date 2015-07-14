using System;
using System.IO;
using System.Linq;

namespace The_Major_Element
{
    internal static class TheMajorElement
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

                    var elements = line.Trim().Split(',');
                    var threshold = elements.Length/2;

                    var majElem = "None";
                    var groups = elements.GroupBy(item => item);
                    foreach (var group in groups)
                    {
                        if (group.Count() > threshold)
                            majElem = group.Key;
                    }

                    Console.WriteLine(majElem);
                }
            }
        }
    }
}