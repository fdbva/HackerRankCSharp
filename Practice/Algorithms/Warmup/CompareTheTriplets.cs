using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the solve function below.
     */
    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2) {
        var results = new [] {0, 0};
        
        ResolvePoints(a0, b0, results);
        ResolvePoints(a1, b1, results);
        ResolvePoints(a2, b2, results);
        
        return results;
    }
    static void ResolvePoints(int aInput, int bInput, int[] results){
        if(aInput > bInput)
            results[0] += 1;
        if(bInput > aInput)
            results[1] += 1;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] a0A1A2 = Console.ReadLine().Split(' ');

        int a0 = Convert.ToInt32(a0A1A2[0]);

        int a1 = Convert.ToInt32(a0A1A2[1]);

        int a2 = Convert.ToInt32(a0A1A2[2]);

        string[] b0B1B2 = Console.ReadLine().Split(' ');

        int b0 = Convert.ToInt32(b0B1B2[0]);

        int b1 = Convert.ToInt32(b0B1B2[1]);

        int b2 = Convert.ToInt32(b0B1B2[2]);

        int[] result = solve(a0, a1, a2, b0, b1, b2);

        tw.WriteLine(string.Join(" ", result));

        tw.Flush();
        tw.Close();
    }
}

