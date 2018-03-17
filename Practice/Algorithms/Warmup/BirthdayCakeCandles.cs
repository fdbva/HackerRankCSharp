using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int birthdayCakeCandles(int n, int[] ar)
    {
        var candles = ar.ToList();
        var biggestCandleSize = candles.Max();
        return candles.Count(x => x == biggestCandleSize);

        //var biggestCandle = long.MinValue;
        //foreach (var a in ar)
        //{
        //    if (a > biggestCandle)
        //        biggestCandle = a;
        //}

        //var blownCount = 0;
        //foreach (var a in ar)
        //{
        //    if (a == biggestCandle)
        //        blownCount++;
        //}

        //return blownCount;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}


