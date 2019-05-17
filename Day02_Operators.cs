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

    // Complete the solve function below.
    static void Solve(double meal_cost, int tip_percent, int tax_percent) 
    {
    double tip = Convert.ToDouble(tip_percent);
    double tax = Convert.ToDouble(tax_percent);
    double withTax = meal_cost * (tax / 100);
    double withTip = meal_cost * (tip / 100);
    double totalCost = withTax + withTip + meal_cost;

    Console.WriteLine("{0:0}", totalCost);
    }

    static void Main(string[] args) 
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        Solve(meal_cost, tip_percent, tax_percent);
    }
}
