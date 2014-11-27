using System;
using System.Collections.Generic;
using System.IO;

namespace Multiply_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();
            var firstList = new List<int>();
            var secondList = new List<int>();

            using (sr)
            {
                var line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            foreach (var s in lines)
            {
                int number;
                var lists = s.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                var splitFirstList = lists[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var splitSecondList = lists[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in splitFirstList)
                {
                    number = Convert.ToInt32(item);
                    firstList.Add(number);
                }

                foreach (var item in splitSecondList)
                {
                    number = Convert.ToInt32(item);
                    secondList.Add(number);
                }

                for (var j = 0; j < firstList.Count; j++)
                {
                    var multiply = firstList[j] * secondList[j];
                    Console.Write(multiply + " ");
                }
                Console.WriteLine();
                firstList = new List<int>();
                secondList = new List<int>();
            }
        }
    }
}