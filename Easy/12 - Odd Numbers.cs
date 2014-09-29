using System;

namespace OddNumbers
{
    class Program
    {
        static void Main()
        {
            for (var i = 1; i < 100; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}