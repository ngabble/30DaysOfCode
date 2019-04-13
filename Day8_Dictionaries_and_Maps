using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        buildDict(phonebook);
        printDict(phonebook);
    }
    static Dictionary<string, string> buildDict(Dictionary<string, string> phonebook)
    {
        int dictSize = Convert.ToInt32(Console.ReadLine());
        string name = "";
        String number = "";

        for (int ii = 0; ii < dictSize; ii++)
        {
            string entry = Console.ReadLine();
            string[] entries = entry.Split(' ');
            name = entries[0];
            number = entries[1];
            phonebook.Add(name, number);

            /*Dictionary<name, number> phonebook = new Dictionary<name, number>()
            {
                {name, number}  
            };
            */
        }
        return phonebook;
    }
    static void printDict(Dictionary<string, string> phonebook)
    {
        bool test = true;
        do
        {
            string query = Console.ReadLine();

            if (phonebook.TryGetValue(query, out string description))
            {
                Console.WriteLine("{0}={1}", query, description);
            }
            else if (query == "")
            {
                test = false;
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }
        while (test == true);
        
    }
}
