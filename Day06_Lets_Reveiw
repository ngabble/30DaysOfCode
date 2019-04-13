using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int T = Convert.ToInt32(Console.ReadLine());
       
        for (int v = 0; v < T; v++)
        {
            string even = "";
            string odd = "";
            string myString = Console.ReadLine();
            var myCharArray = myString.ToCharArray();
           
            for(int i = 0; i < myString.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    char E = myCharArray[i];
                    even = even + E;
                }
                else
                {
                    char O = myCharArray[i];
                    odd = odd + O;
                }
            }
            Console.WriteLine(even + " " + odd);
                
        }
    }
}
