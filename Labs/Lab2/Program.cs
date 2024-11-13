using System;
using System.IO;

namespace Labs.Lab2
{
    public class Program
    {
        // Метод для зчитування файлів і виконання обчислень
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

            int result = CalculateMinimumTime(N, A, B, C);
            File.WriteAllText(outputFilePath, result.ToString());
        }

        // Метод обчислення мінімального часу
        public static int CalculateMinimumTime(int N, int[] A, int[] B, int[] C)
        {
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

            return dp[N];
        }
    }
}
