using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Array_Count_Even_and_Odd_num
    {
        public void CountEvenOdd()
            {
                int[] arr = new int[10];
                Console.WriteLine("Enter 10 integers:");
                for (int i = 0; i < 10; i++)
                    arr[i] = int.Parse(Console.ReadLine());

                int even = 0, odd = 0;
                foreach (int num in arr)
                {
                    if (num % 2 == 0)
                        even++;
                    else
                        odd++;
                }

                Console.WriteLine($"Even numbers: {even}");
                Console.WriteLine($"Odd numbers: {odd}");
            }
        
    }
}
