using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_018
{
    internal class Array_Search_Element
    {
        public void SearchElement()
            {
                Console.Write("Enter number of elements in array: ");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];

                Console.WriteLine($"Enter {size} integers:");
                for (int i = 0; i < size; i++)
                    arr[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter number to search: ");
                int search = int.Parse(Console.ReadLine());

                bool found = false;
                foreach (int num in arr)
                {
                    if (num == search)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    Console.WriteLine($"{search} found in array!");
                else
                    Console.WriteLine($"{search} not found in array.");
            }
       
    }
}

