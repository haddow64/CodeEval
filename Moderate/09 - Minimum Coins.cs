using System;
using System.IO;

namespace Minimum_Coins
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (var inputLine in File.ReadAllLines(args[0]))
            {
                Console.WriteLine(NumCoins(Convert.ToInt32(inputLine)));
            }
        }

        private static int NumCoins(int n)
        {
            var count = 0;
            while (n >= 5)
            {
                n -= 5;
                ++count;
            }
            while (n >= 3)
            {
                n -= 3;
                ++count;
            }

            count += n;

            return count;
        }
    }
}