using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void primeCheck (int[] cases)
    {
        foreach (int num in cases)
        {
            bool isPrime = true;
		  int limit = Math.Sqrt(num);
            for (int i = 1; i <= limit; i++)
            {
                if (num == 1)
                {
                    isPrime = false;
                    break;
                }
                if (num % i == 0 && i != 1)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == false)
            {
                Console.WriteLine("Not prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
    static void Main(String[] args) 
    {
        int numberOfCases = Int32.Parse(Console.ReadLine());
        int[] cases = new int[numberOfCases];

        for (int ii = 0; ii < numberOfCases; ++ii)
        {
            cases[ii] = Int32.Parse(Console.ReadLine());
        }
        primeCheck(cases);
    }
}
