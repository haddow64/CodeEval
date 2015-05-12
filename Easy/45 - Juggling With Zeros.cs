using System;
using System.Collections.Generic;
using System.IO;

namespace JugglingWithZeros
{
    static class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(args[0]);
            var lines = new List<string>();

            using (sr)
            {
                var line = sr.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            foreach (var lin in lines)
            {
                var splitLine = lin.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var queue = new Queue<string>();
                var binaryNumber = "";

                foreach (var s in splitLine)
                {
                    queue.Enqueue(s);
                }


                while (queue.Count > 0)
                {
                    var zeros = queue.Dequeue();
                    string add;

                    if (zeros == "00")
                    {
                        add = queue.Dequeue();
                        var addOnes = new string('1', add.Length);
                        binaryNumber += addOnes;

                    }
                    if (zeros != "0") continue;
                    add = queue.Dequeue();
                    binaryNumber += add;
                }

                var result = Convert.ToInt64(binaryNumber, 2);
                Console.WriteLine(result);
            }
        }
    }
}