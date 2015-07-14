using System;
using System.IO;

namespace Raching_Chars
{
    internal static class RacingChars
    {
        private static char update_direction(int prev, int index)
        {
            return index < prev ? '/' : (index == prev ? '|' : '\\');
        }

        public static void Main(string[] args)
        {
            var direction = '|';
            var prev = -1;

            using (var reader = new StreamReader(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (null == line)
                        continue;

                    var outputLine = line.Trim().ToCharArray();
                    var gateIndex = line.IndexOf('_');
                    if (prev == -1)
                        prev = gateIndex;
                    var checkpointIndex = line.IndexOf('C');
                    if (checkpointIndex == -1)
                    {
                        direction = update_direction(prev, gateIndex);
                        outputLine[gateIndex] = direction;
                        prev = gateIndex;
                    }
                    else
                    {
                        direction = update_direction(prev, checkpointIndex);
                        outputLine[checkpointIndex] = direction;
                        prev = checkpointIndex;
                    }
                    Console.WriteLine(new string(outputLine));
                }
            }
        }
    }
}