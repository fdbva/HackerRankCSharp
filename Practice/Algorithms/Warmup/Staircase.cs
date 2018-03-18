using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (var i = 1; i < n + 1; i++)
            Console.WriteLine(new string('#', i).PadLeft(n, ' '));
    }
}

