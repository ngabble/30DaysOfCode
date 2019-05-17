using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System;

class Solution 
{
    static void Main(string[] args) 
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> gmailNames = new List<string>();
        for (int i = 0; i < N; i++) 
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');
            string firstName = firstNameEmailID[0];
            string emailID = firstNameEmailID[1];
            bool isGmail = emailID.EndsWith("@gmail.com");
                if (isGmail)
                {
                    gmailNames.Add(firstName);
                }
        }
        gmailNames.Sort();

        foreach (string name in gmailNames)
        {
            Console.WriteLine(name);
        }
    }
}

