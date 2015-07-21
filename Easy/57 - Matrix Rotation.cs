using System;
using System.IO;

namespace Matrix_Rotation
{
    static class MatrixRotation
    {
        public static void Main(string[] args)
        {
            using (var sr = new StreamReader(args[0]))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string result = RotateMatrix(line);
                        Console.WriteLine(result);
                    }
                }
            }
        }

        private static string RotateMatrix(string line)
        {
            var matrix = line.Trim().Split();
            var n = (int)Math.Sqrt(matrix.Length);
            var result = "";

            for (var j = 0; j < n; j++)
                for (var i = n - 1; i > -1; i--)
                    result += matrix[(i * n) + j] + " ";
            return result;
        }
    }
}