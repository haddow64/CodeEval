using System;
 
class Program
{
    static void Main(string[] args)
    {
        int numOfPrimes = 0, index = 2, sumOfPrimes = 0;
 
        while (numOfPrimes != 1000)
        {
            if(isPrime(index))
            {
                numOfPrimes++;
                sumOfPrimes += index;
            }
 
            index++;
        }
 
        Console.WriteLine(sumOfPrimes);
    }
 
    public static bool isPrime(int number)
    {
        for (int i = 2; i < (number / 2 + 1); i++)
        {
            if((number % i) == 0)
            {
                return false;
            }
        }
 
        return true;
    }
}