using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Simple_Cal
    {
            public void Calculate()
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose operation: +, -, *, /");
                char op = char.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Console.WriteLine($"Result: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                            Console.WriteLine($"Result: {num1 / num2}");
                        else
                            Console.WriteLine("Division by zero not allowed!");
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }
            }
      
    }
}
