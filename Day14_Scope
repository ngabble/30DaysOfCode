using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] a)
    {elements = a;}

public int computeDifference()
{
Array.Sort(elements, 0, elements.Length);
int n = elements.Length;
int largest = elements[n-1];
int smallest = elements[0];
    maximumDifference = largest - smallest;
    return maximumDifference;
}
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}

