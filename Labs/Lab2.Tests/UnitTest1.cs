using System;
using Xunit;
using Labs.Lab2; 

namespace Labs.Lab2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_SinglePerson()
        {
            int N = 1;
            int[] A = { 5 };
            int[] B = { 0 };
            int[] C = { 0 };
            int expected = 5;

            int result = Program.CalculateMinimumTime(N, A, B, C);
            Console.WriteLine($"Test_SinglePerson: Expected={expected}, Result={result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_TwoPeople_OptimalPair()
        {
            int N = 2;
            int[] A = { 10, 10 };
            int[] B = { 15, 0 };
            int[] C = { 0, 0 };
            int expected = 15;

            int result = Program.CalculateMinimumTime(N, A, B, C);
            Console.WriteLine($"Test_TwoPeople_OptimalPair: Expected={expected}, Result={result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ThreePeople_OptimalTriple()
        {
            int N = 3;
            int[] A = { 10, 20, 30 };
            int[] B = { 25, 30, 0 };
            int[] C = { 40, 0, 0 };
            int expected = 40;

            int result = Program.CalculateMinimumTime(N, A, B, C);
            Console.WriteLine($"Test_ThreePeople_OptimalTriple: Expected={expected}, Result={result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_FivePeople_MixedPurchases()
        {
            int N = 5;
            int[] A = { 5, 10, 15, 20, 25 };
            int[] B = { 12, 20, 25, 30, 0 };
            int[] C = { 18, 30, 35, 40, 0 };
            int expected = 47;

            int result = Program.CalculateMinimumTime(N, A, B, C);
            Console.WriteLine($"Test_FivePeople_MixedPurchases: Expected={expected}, Result={result}");
            Assert.Equal(expected, result);
        }

       [Fact]
        public void Test_LargeInput()
        {
            int N = 5;
            int[] A = { 1000, 1000, 1000, 1000, 1000 };
            int[] B = { 1500, 1500, 1500, 1500, 0 };
            int[] C = { 2000, 2000, 2000, 0, 0 };
            int expected = 3500;  

            int result = Program.CalculateMinimumTime(N, A, B, C);
            Console.WriteLine($"Test_LargeInput: Expected={expected}, Result={result}");
            Assert.Equal(expected, result);
        }

    }
}
