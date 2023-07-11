using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static object answer;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Devision");

            Console.Write("Enter your choice:");

            string input = Console.ReadLine();

            Console.Write("Enter number1: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter number2:");
            double number2 = double.Parse(Console.ReadLine());

            if (input == "1")
            {
                answer = object.sum(number1, number2);
            }
            else if (input == "2")
            {
                answer = object.sub(number1, number2);
            }
            Console.ReadKey();
            }
        }
    }

