using System;
using System.IO;
using Lab3Library;

namespace Labs.Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string inputFilePath = Path.Combine("Labs", "Lab3",  "INPUT.TXT");
            string outputFilePath = Path.Combine("Labs", "Lab3", "OUTPUT.TXT");

            var result = FieldAnalyzer.Analyze(inputFilePath, outputFilePath);

        }
    }
}
