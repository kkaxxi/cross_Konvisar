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
            Lab1 lab1 = new Lab1();

            lab1.ExecuteLab1(inputFile, outputFile);

        }
        public void RunLab2(string inputFile, string outputFile)
        {
            Lab2 lab2 = new Lab2();

            lab2.ExecuteLab2(inputFile, outputFile);

        }
        public void RunLab3(string inputFile, string outputFile)
        {
            Lab3 lab3 = new Lab3();

            lab3.ExecuteLab3(inputFile, outputFile);

        }
    }
}