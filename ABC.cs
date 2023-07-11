using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter value for num2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Answer is " + getsum(num1, num2));

            Console.ReadKey();

        }
        public static int getsum(int num1, num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
