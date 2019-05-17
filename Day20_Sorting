using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static int bubbleSort(int n, int[] a)
    {
        int numberOfSwaps = 0;
        for (int i = 0; i < n; i++) 
        {
            int tempNum = 0;

            for (int j = 0; j < n - 1; j++) 
            {
                if (a[j] > a[j + 1]) 
                {
                    tempNum = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tempNum;
                    numberOfSwaps++;
                }
            }
            if (numberOfSwaps == 0) 
            {
                return numberOfSwaps;
            }
        }
        return numberOfSwaps;
    }
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int numSwaps = bubbleSort(n, a);
        Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[n-1]}");
    }
}

