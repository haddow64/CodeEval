using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Knight_Moves
{
    class KnightMovesSolution
    {
        private static void Main(string[] args)
        {
            foreach (var line in File.ReadAllLines(args[0]).ToList())
            {
                Console.WriteLine(PossibleKnightMove(line.ToCharArray()));
            }
        }

        private static string PossibleKnightMove(char[] knightPosition)
        {
            const string cBoardColumns = "abcdefgh";
            const string nBoardRows = "12345678";

            var cColumn = new char[4];
            var cPosition = cBoardColumns.IndexOf(knightPosition[0]);
            if (cPosition - 2 >= 0) cColumn[0] = cBoardColumns[cPosition - 2];
            if (cPosition - 1 >= 0) cColumn[1] = cBoardColumns[cPosition - 1];
            if (cPosition + 1 <= cBoardColumns.Length - 1) cColumn[2] = cBoardColumns[cPosition + 1];
            if (cPosition + 2 <= cBoardColumns.Length - 1) cColumn[3] = cBoardColumns[cPosition + 2];

            var nRow = new char[4];
            var nPosition = nBoardRows.IndexOf(knightPosition[1]);
            if (nPosition - 2 >= 0) nRow[0] = nBoardRows[nPosition - 2];
            if (nPosition - 1 >= 0) nRow[1] = nBoardRows[nPosition - 1];
            if (nPosition + 1 <= cBoardColumns.Length - 1) nRow[2] = nBoardRows[nPosition + 1];
            if (nPosition + 2 <= cBoardColumns.Length - 1) nRow[3] = nBoardRows[nPosition + 2];

            var possibilities = new List<string>
            {
                (cColumn[1] + "" + nRow[0]),
                (cColumn[1] + "" + nRow[3]),
                (cColumn[2] + "" + nRow[0]),
                (cColumn[2] + "" + nRow[3]),
                (cColumn[0] + "" + nRow[1]),
                (cColumn[0] + "" + nRow[2]),
                (cColumn[3] + "" + nRow[1]),
                (cColumn[3] + "" + nRow[2])
            };

            return string.Join(" ", possibilities.Select(a => a).Where(a => !a.Contains('\0')).OrderBy(a => a));
        }
    }
}