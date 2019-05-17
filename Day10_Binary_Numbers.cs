using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    static int MaxRepeating(string binary)
    {
        int length = binary.Length;
        int count = 0;
        char result = binary[0];

        for (int i = 0; i < length; i++)
        {
            int cur_count = 1;
            for (int j = i + 1; j < length; j++)
            {
                if (binary[i] != binary[j])
                { break; }
                else
                { cur_count++; }
            }

            if (cur_count > count)
            {
                count = cur_count;
            }
        }
        return count;
    }

    static string ConvertToBinary(int n)
    {
        int tempNum = n;
        int bit;
        string tempString = "";
        string binary = "";

        do
        {

            bit = tempNum % 2;
            tempNum = tempNum / 2;
            tempString = Convert.ToString(bit);
            binary += tempString;


        } while (tempNum > 0);
        return binary;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = ConvertToBinary(n);
        int count = MaxRepeating(binary);
        Console.WriteLine(count);
    }
}
