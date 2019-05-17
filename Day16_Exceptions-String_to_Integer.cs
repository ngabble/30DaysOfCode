using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void TryCatch (string S)
    {
       try
       {
           int attempt = Int32.Parse(S);
           Console.WriteLine(attempt);
       }
       catch (FormatException)
       {
           Console.WriteLine("Bad String");
       }
    }
    static void Main(String[] args) {
        string S = Console.ReadLine();
        TryCatch(S);
    }
}

