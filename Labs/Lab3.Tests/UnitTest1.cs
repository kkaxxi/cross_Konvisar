using System;
using System.IO;
using Xunit;
using Labs.Lab3;
using Lab3Library;



namespace Labs.Lab3.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1_AllShipsIntact()
        {
            string input = 
@"4 4
S---
-S--
--S-
---S";

            string expectedOutput = "4 0 0";

            RunTest(input, expectedOutput);
        }

        [Fact]
        public void Test2_DamagedShips()
        {
            string input = 
@"4 4
S---
-SX-
--S-
X--S";

            string expectedOutput = "2 1 1";

            RunTest(input, expectedOutput);
        }

        [Fact]
        public void Test3_DestroyedShips()
        {
            string input = 
@"4 4
SX--
-XX-
--S-
---S";

            string expectedOutput = "1 1 0";

            RunTest(input, expectedOutput);
        }

        [Fact]
        public void Test4_EmptyField()
        {
            string input = 
@"4 4
----
----
----
----";

            string expectedOutput = "0 0 0";

            RunTest(input, expectedOutput);
        }

        [Fact]
        public void Test5_MixedCase()
        {
            string input = 
@"5 5
S----
-SX--
--S--
XXS--
---S-";

            string expectedOutput = "2 1 0";

            RunTest(input, expectedOutput);
        }

        private void RunTest(string inputContent, string expectedOutput)
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDirectory);

            try
            {
                string inputFilePath = Path.Combine(tempDirectory, "INPUT.TXT");
                string outputFilePath = Path.Combine(tempDirectory, "OUTPUT.TXT");

                // Створення тимчасового вхідного файлу
                File.WriteAllText(inputFilePath, inputContent);

                // Виклик програми
                FieldAnalyzer.Analyze(inputFilePath, outputFilePath);

                // Читання результату
                string actualOutput = File.ReadAllText(outputFilePath).Trim();

                // Перевірка результату
                Assert.Equal(expectedOutput, actualOutput);
            }
            finally
            {
                // Видалення тимчасових файлів і директорій
                if (Directory.Exists(tempDirectory))
                {
                    Directory.Delete(tempDirectory, true);
                }
            }
        }
    }
}
