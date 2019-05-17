using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    internal static int CalculateFine(string[] dateReturnedDMY, string[] dueDateDMY)
    {
        int dayR = Int32.Parse(dateReturnedDMY[0]);
        int monthR = Int32.Parse(dateReturnedDMY[1]);
        int yearR = Int32.Parse(dateReturnedDMY[2]);

        int dayD = Int32.Parse(dueDateDMY[0]);
        int monthD = Int32.Parse(dueDateDMY[1]);
        int yearD = Int32.Parse(dueDateDMY[2]);
        
   int fine = 0;
        if (dayR == dayD && monthR == monthD && yearR == yearD)
        {
            return fine;
        }
        else if (yearD < yearR)
        {   
            fine = 10000;
        }
        else if (monthR == monthD && yearR == yearD && dayR > dayD)
        {
            fine = 15 * (dayR - dayD);
        }
        else if (yearR == yearD && monthR > monthD)
        {
            fine = 500 * (monthR - monthD);
        }
        else
        {
        return fine;
        }
        return fine;
    }
    static void Main(String[] args) 
    {
        string dateReturnedString = Console.ReadLine();
        string dueDateString = Console.ReadLine();
        
        string[] dateReturnedDMY = dateReturnedString.Split(' ');
        string[] dueDateDMY = dueDateString.Split(' ');

        int fine = CalculateFine(dateReturnedDMY, dueDateDMY);
        Console.WriteLine(fine);

    }
}

