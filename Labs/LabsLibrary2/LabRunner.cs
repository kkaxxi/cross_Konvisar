using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary2
{
    public class LabRunner
    {
        public void RunLab1(string inputFile, string outputFile)
        {
            // Create an instance of the FindLength class
            Lab1 lab1 = new Lab1();

            // Call the Find method to execute the functionality
            lab1.ExecuteLab1(inputFile, outputFile);

        }
        public void RunLab2(string inputFile, string outputFile)
        {
            // Create an instance of the FindLength class
            Lab2 lab2 = new Lab2();

            // Call the Find method to execute the functionality
            lab2.ExecuteLab2(inputFile, outputFile);

        }
        public void RunLab3(string inputFile, string outputFile)
        {
            // Create an instance of the FindLength class
            Lab3 lab3 = new Lab3();

            // Call the Find method to execute the functionality
            lab3.ExecuteLab3(inputFile, outputFile);

        }
    }
}