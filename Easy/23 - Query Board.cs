using System;
using System.Collections.Generic;
using System.IO;

namespace QueryBoard
{
    internal class QueryBoard
    {
        private static void Main(string[] args)
        {
            var matrix = new int[256, 256];
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();
            var separator = new[] {' '};
            int sum = 0;


            using (sr)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            foreach (string selectedLine in lines)
            {
                string[] queryFromLine = selectedLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string query = queryFromLine[0];

                int value;
                int row;
                int col;
                switch (query)
                {
                    case "SetRow":
                        row = Convert.ToInt32(queryFromLine[1]);
                        value = Convert.ToInt32(queryFromLine[2]);

                        for (int cols = 0; cols < matrix.GetLength(1); cols++)
                        {
                            matrix[row, cols] = value;
                        }
                        break;
                    case "SetCol":
                        col = Convert.ToInt32(queryFromLine[1]);
                        value = Convert.ToInt32(queryFromLine[2]);

                        for (int rows = 0; rows < matrix.GetLength(0); rows++)
                        {
                            matrix[rows, col] = value;
                        }
                        break;
                    case "QueryRow":
                        row = Convert.ToInt32(queryFromLine[1]);

                        for (int cols = 0; cols < matrix.GetLength(1); cols++)
                        {
                            sum += matrix[row, cols];
                        }

                        Console.WriteLine(sum);
                        sum = 0;
                        break;
                    case "QueryCol":
                        col = Convert.ToInt32(queryFromLine[1]);

                        for (int rows = 0; rows < matrix.GetLength(0); rows++)
                        {
                            sum += matrix[rows, col];
                        }

                        Console.WriteLine(sum);
                        sum = 0;
                        break;
                    default:
                        Console.WriteLine("error!");
                        break;
                }
            }
        }
    }
}