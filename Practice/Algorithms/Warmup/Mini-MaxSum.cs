using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void miniMaxSum(int[] arr)
    {
        var min = long.MaxValue;
        var max = long.MinValue;
        var sum = 0L;
        foreach (var ar in arr)
        {
            if (min > ar)
                min = ar;
            if (max < ar)
                max = ar;
            sum += ar;
        }
        Console.WriteLine($"{sum - max} {sum - min}");
    }

    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        miniMaxSum(arr);
    }
}


