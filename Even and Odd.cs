using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Even_and_Odd
       
        {
            public void CheckEvenOdd()
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                    Console.WriteLine($"{number} is Even.");
                else
                    Console.WriteLine($"{number} is Odd.");
            }
        }
}
