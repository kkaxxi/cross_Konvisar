using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] inputLines = File.ReadAllLines("INPUT.TXT");
        int n = int.Parse(inputLines[0]); 

        List<int> queries = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            queries.Add(int.Parse(inputLines[i]));
        }

        List<(int, int)> losingPairs = GenerateLosingPairs(queries.Max());

        using (StreamWriter writer = new StreamWriter("OUTPUT.TXT"))
        {
            foreach (int k in queries)
            {
                (int a, int b) = losingPairs[k];
                writer.WriteLine($"{a} {b}");
            }
        }
    }

    static List<(int, int)> GenerateLosingPairs(int maxK)
    {
        List<(int, int)> losingPairs = new List<(int, int)>();
        double phi = (1 + Math.Sqrt(5)) / 2;  

        for (int k = 0; k <= maxK; k++)
        {
            int a = (int)(k * phi);
            int b = a + k;
            losingPairs.Add((a, b));
        }

        return losingPairs;
    }
}
