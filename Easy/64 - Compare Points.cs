using System;
using System.IO;
using System.Linq;

namespace Compare_Points
{
    internal static class ComparePoints
    {
        private static void Main(string[] args)
        {
            foreach (var line in File.ReadAllLines(args[0]).ToList())
            {
                var pointValue = line.Split().Select(a => Convert.ToInt32(a)).ToArray();
                var pointO = pointValue[0];
                var pointP = pointValue[1];
                var pointQ = pointValue[2];
                var pointR = pointValue[3];

                var result = "";

                if (pointO == pointQ)
                {
                    if (pointP == pointR)
                        result = "here";
                    if (pointP < pointR)
                        result = "N";
                    if (pointP > pointR)
                        result = "S";
                }

                if (pointO < pointQ)
                {
                    if (pointP == pointR)
                        result = "E";
                    if (pointP < pointR)
                        result = "NE";
                    if (pointP > pointR)
                        result = "SE";
                }

                if (pointO > pointQ)
                {
                    if (pointP == pointR)
                        result = "W";
                    if (pointP < pointR)
                        result = "NW";
                    if (pointP > pointR)
                        result = "SW";
                }

                Console.WriteLine(result);
            }
        }
    }
}