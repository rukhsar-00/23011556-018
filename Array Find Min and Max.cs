using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Array_Find_Min_and_Max
    {
            public void FindMaxMin()
            {
                int[] arr = new int[10];

                Console.WriteLine("Enter 10 integers:");
                for (int i = 0; i < 10; i++)
                    arr[i] = int.Parse(Console.ReadLine());

                int max = arr[0], min = arr[0];

                foreach (int num in arr)
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                }

                Console.WriteLine($"Maximum: {max}");
                Console.WriteLine($"Minimum: {min}");
            }
       
    }
}

