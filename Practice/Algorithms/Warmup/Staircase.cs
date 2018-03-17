using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void staircase(int n)
    {
        for (var i = 1; i < n+1; i++)
        {
            for (var j = n; j > 0; j--)
            {
                Console.Write(i < j ? " " : "#");
            }

            Console.WriteLine();
        }
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}

