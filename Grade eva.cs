using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Grade_eva
    {
        public void EvaluateGrade()
            {
                Console.Write("Enter your marks (0–100): ");
                int marks = int.Parse(Console.ReadLine());

                if (marks >= 85)
                    Console.WriteLine("Grade: A");
                else if (marks >= 70)
                    Console.WriteLine("Grade: B");
                else if (marks >= 55)
                    Console.WriteLine("Grade: C");
                else if (marks >= 40)
                    Console.WriteLine("Grade: D");
                else
                    Console.WriteLine("Grade: F");
            }
        
    }
}
