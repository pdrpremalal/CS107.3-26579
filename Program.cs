using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayManipulator
    {
        static void Main(string[] args)
        {
            //method1
            int[] num1 = new int[10];

            //method2
            int[] num2 = new int[3] { 2, 3, 4 };

            //method3
            int[] num3 = new int[] { 5, 6, 7 };

            //method4
            int[] num4 = { 12, 34, 655 };

            Console.WriteLine("Enter 10 values: ");
            for (int i = 0; i < 10; i++)
            {
                num1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n\n");

            //printing the array
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{num1[i]}");
                Array.Reverse(num1);
                Console.WriteLine($"{num1}");
            }

            int min = num1[0];
            int max = num1[0];
            int tot = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] < min)
                {
                    min = num1[i];
                }
                if (num1[i] > max)
                {
                    max = num1[i];
                }
                tot = num1[i] + tot;
            }
            Console.WriteLine($"max is {max}");
            Console.WriteLine($"min is {min}");
            Console.WriteLine($"avg is {tot / num1.Length}");
            Console.ReadLine();

        }
    }
}

            


        
    

