using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Labs.Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string inputFilePath = Path.Combine("Labs", "Lab1", "INPUT.TXT");
            string outputFilePath = Path.Combine("Labs", "Lab1", "OUTPUT.TXT");

            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine($"Error: File not found at path {inputFilePath}");
                return;
            }

            string[] inputLines;
            try
            {
                inputLines = File.ReadAllLines(inputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading the file: {ex.Message}");
                return;
            }

            int n;
            if (!int.TryParse(inputLines[0], out n) || n < 1)
            {
                Console.WriteLine("Error: Invalid number of tests in the first line.");
                return;
            }

            List<int> queries = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (int.TryParse(inputLines[i], out int query) && query >= 0)
                {
                    queries.Add(query);
                }
                else
                {
                    Console.WriteLine($"Error: Invalid value in line {i + 1} of the file INPUT.TXT.");
                    return;
                }
            }

            List<(int, int)> losingPairs = GenerateLosingPairs(queries.Max());

            try
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach (int k in queries)
                    {
                        (int a, int b) = losingPairs[k];
                        writer.WriteLine($"{a} {b}");
                    }
                }
                Console.WriteLine($"Results successfully written to {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while writing to OUTPUT.TXT: {ex.Message}");
            }
        }

        public static List<(int, int)> GenerateLosingPairs(int maxK)
        {
            if (maxK < 0)
                throw new ArgumentOutOfRangeException(nameof(maxK), "Value cannot be negative.");

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
}
