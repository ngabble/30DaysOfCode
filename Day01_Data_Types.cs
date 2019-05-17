using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int newNum;
        double newDoub;
        string newWord;
       
        // Read and save an integer, double, and String to your variables.
        string n = Console.ReadLine();
        newNum = int.Parse(n);
        
        string v = Console.ReadLine();
        newDoub = double.Parse(v);
        
        newWord = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + newNum);
        
        // Print the sum of the double variables on a new line.
        newDoub = newDoub + d;
        Console.WriteLine(newDoub.ToString("0.0"));

        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + newWord);
        
        // The 's' variable above should be printed first.

    }
}
