using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void plusMinus(int[] arr)
    {
        var positiveCount = 0.0d;
        var negativeCount = 0.0d;
        foreach (var ar in arr)
        {
            if (ar > 0)
            {
                positiveCount++;
            }
            else if (ar < 0)
            {
                negativeCount++;
            }
        }
        Console.WriteLine(positiveCount / arr.Length);
        Console.WriteLine(negativeCount / arr.Length);
        Console.WriteLine((arr.Length - positiveCount - negativeCount) / arr.Length);
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        plusMinus(arr);
    }
}

