using System;
using System.IO;
using System.Linq;

namespace Overlapping_Rectangles
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            foreach (var inputLine in File.ReadAllLines(args[0]).Select(line => line.Split(',')))
            {
                var coordinates = Array.ConvertAll(inputLine, int.Parse);

                var p1 = new Point(coordinates[0], coordinates[1]);
                var p2 = new Point(coordinates[2], coordinates[3]);
                var p3 = new Point(coordinates[4], coordinates[5]);
                var p4 = new Point(coordinates[6], coordinates[7]);

                if (Math.Min(p1.GetX(), p2.GetX()) <= Math.Max(p3.GetX(), p4.GetX()) &&
                    Math.Max(p1.GetX(), p2.GetX()) >= Math.Min(p3.GetX(), p4.GetX()) &&
                    Math.Max(p1.GetY(), p2.GetY()) >= Math.Min(p3.GetY(), p4.GetY()) &&
                    Math.Min(p1.GetY(), p2.GetY()) <= Math.Max(p3.GetY(), p4.GetY()))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        private class Point
        {
            private readonly int _x;
            private readonly int _y;

            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public int GetX()
            {
                return _x;
            }

            public int GetY()
            {
                return _y;
            }
        }
    }
}