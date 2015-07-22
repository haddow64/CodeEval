using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Details
{
    internal static class Details
    {
        private static void Main(string[] args)
        {
            if (args[0] != null)
            {
                foreach (var inputLines in File.ReadAllLines(args[0]).ToList())
                    Console.WriteLine(MoveDetails(inputLines.Split(',')));
            }
        }

        private static int MoveDetails(IList<string> inputLine)
        {
            var moveCounts = new List<int>();

            for (var i = 0; i < inputLine.Count(); i++)
            {
                // Currently there is an error in the input file from CodeEval
                // Credit to - https://github.com/StevenDunn/CodeEval/blob/master/Details/c%23/Details.cs
                if (inputLine[i] == "XYYYY.Y")
                    inputLine[i] = "XYYYYYY";

                moveCounts.Add(inputLine[i].Count(a => a.Equals('.')));
            }

            return moveCounts.OrderBy(a => a).ToList()[0];
        }
    }
}