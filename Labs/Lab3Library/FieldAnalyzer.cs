using System;
using System.Collections.Generic;
using System.IO;

namespace Lab3Library
{
    public class FieldAnalyzer
    {
        public static (int intact, int damaged, int destroyed) Analyze(string inputFilePath, string outputFilePath)
        {
            try
            {
                string[] input = File.ReadAllLines(inputFilePath);
                Console.WriteLine($"Input file successfully read from {inputFilePath}.");

                string[] dimensions = input[0].Split(' ');
                int n = int.Parse(dimensions[0]);
                int m = int.Parse(dimensions[1]);
                Console.WriteLine($"Field dimensions: {n} x {m}.");

                char[,] arr = new char[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        char x = input[i + 1][j];
                        arr[i, j] = x == '-' ? (char)0 : (x == 'S' ? (char)1 : (char)2);
                    }
                }

                bool[,] used = new bool[n, m];
                int[] ships = new int[3]; 
                List<(int, int)> stack = new List<(int, int)>();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (arr[i, j] != 0 && !used[i, j])
                        {
                            used[i, j] = true;
                            stack.Add((i, j));

                            int nS = 0, nX = 0;

                            while (stack.Count > 0)
                            {
                                var (x, y) = stack[^1];
                                stack.RemoveAt(stack.Count - 1);

                                if (arr[x, y] == 1) nS++;
                                if (arr[x, y] == 2) nX++;

                                foreach (var (dx, dy) in new[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
                                {
                                    int nx = x + dx, ny = y + dy;
                                    if (nx >= 0 && nx < n && ny >= 0 && ny < m && !used[nx, ny] && arr[nx, ny] != 0)
                                    {
                                        used[nx, ny] = true;
                                        stack.Add((nx, ny));
                                    }
                                }
                            }

                            if (nS > 0 && nX == 0)
                                ships[0]++; 
                            else if (nX > 0 && nS == 0)
                                ships[2]++; 
                            else if (nS > 0 && nX > 0)
                                ships[1]++; 
                        }
                    }
                }

                Console.WriteLine($"Results: Intact ships - {ships[0]}, Damaged ships - {ships[1]}, Destroyed ships - {ships[2]}.");
                File.WriteAllText(outputFilePath, $"{ships[0]} {ships[1]} {ships[2]}");
                Console.WriteLine($"Results successfully written to {outputFilePath}.");

                return (ships[0], ships[1], ships[2]);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: Input file not found at {inputFilePath}. {ex.Message}");
                throw;
            }
        }
    }
}
