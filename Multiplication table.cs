using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Multiplication_table
    {
   public void PrintTable()
            {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine($"Multiplication Table of {n}:");
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{n} x {i} = {n * i}");
            }
       
    }
}
