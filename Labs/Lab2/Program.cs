using System;
using System.IO;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        public static void Main()
        {
            string inputFilePath = Path.Combine("Labs", "Lab2", "Files", "INPUT.TXT");
            string outputFilePath = Path.Combine("Labs", "Lab2", "Files", "OUTPUT.TXT");

            var lines = File.ReadAllLines(inputFilePath);
            int N = int.Parse(lines[0]);
            
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            for (int i = 0; i < N; i++)
            {
                var values = lines[i + 1].Split();
                A[i] = int.Parse(values[0]);
                B[i] = int.Parse(values[1]);
                C[i] = int.Parse(values[2]);
            }

            int[] dp = new int[N + 1];
            
            dp[0] = 0;

            for (int i = 1; i <= N; i++)
            {
                dp[i] = dp[i - 1] + A[i - 1];

                if (i > 1)
                {
                    dp[i] = Math.Min(dp[i], dp[i - 2] + B[i - 2]); 
                }

                if (i > 2)
                {
                    dp[i] = Math.Min(dp[i], dp[i - 3] + C[i - 3]);
                }
            }

            File.WriteAllText(outputFilePath, dp[N].ToString());
        }

    }
}
