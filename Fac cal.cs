using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Fac_cal
    {
            public void CalculateFactorial()
            {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());

                int fact = 1;
                int i = 1;
                while (i <= n)
                {
                    fact *= i;
                    i++;
                }

                Console.WriteLine($"Factorial of {n} is {fact}");
            }
        
    }
}

