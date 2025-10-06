using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Sum_of_numbers
    {
            public void CalculateSum()
            {
                Console.Write("Enter a number n: ");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;
                for (int i = 1; i <= n; i++)
                    sum += i;

                Console.WriteLine($"Sum of first {n} natural numbers is {sum}");
            }
        
    }
}

