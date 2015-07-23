using System;
using System.IO;
using System.Linq;

namespace Mth_To_Last_Element
{
    internal static class MthToLastElement
    {
        public static void Main(string[] args)
        {
            foreach (var element in from line in File.ReadAllLines(args[0])
                select line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                into split
                let length = split.Length - 1
                let index = int.Parse(split[length])
                where index > 0 && length - index >= 0
                select split[length - index])
            {
                Console.WriteLine(element);
            }
        }
    }
}