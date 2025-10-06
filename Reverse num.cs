using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Reverse_num
    {
        public void Reverse()
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int reversed = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    reversed = reversed * 10 + digit;
                    num /= 10;
                }

                Console.WriteLine($"Reversed number: {reversed}");
            }
        
    }
}

