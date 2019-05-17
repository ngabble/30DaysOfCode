using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
using System;

class Solution 
{
    static void Main(string[] args) 
{
        int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++) 
{
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int largest = 0;
            for (int a = 1; a < n; a++)
            {
                for (int b = a + 1; b <= n; b++)
                {
                    int bitwiseAND = a & b;

                    if (largest < bitwiseAND && bitwiseAND < k)
                    {
                        largest = bitwiseAND;
                    }
                }
            }
Console.WriteLine(Convert.ToString(largest));
}        
}
}
