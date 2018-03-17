using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string timeConversion(string s)
    {
        //return DateTime.Parse(s).ToString("HH:mm:ss");
        var ret = s.Substring(0, 8);
        if (s.Contains("PM"))
        {
            if (s.Substring(0, 2) == "12")
                return ret;
            return ret
            .Substring(2, ret.Length - 2)
            .Insert(0, $"{int.Parse(ret.Substring(0, 2)) + 12}");
        }
        if (s.Substring(0, 2) == "12")
            return ret
                .Substring(2, ret.Length - 2)
                .Insert(0, $"00");
        return ret;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}

