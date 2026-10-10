using System;
using System.Collections.Generic;
using System.Text;

//This class to Enter 3 Grades and than add them all up
namespace HelloWorld
{
    internal class Program2
    {
        double grade1, grade2, grade3, total;
        public void EnterGrades()
        {
            Console.WriteLine("Enter Grade 1: ");
            grade1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade 2: ");
            grade2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Grade 3: ");
            grade3 = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateTotal()
        {
            total = grade1 + grade2 + grade3;
            Console.WriteLine("Total of Grades: " + total);
        }

    }
}
