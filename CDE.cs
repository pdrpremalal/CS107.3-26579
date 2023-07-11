using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArithmeticOperations operations = new ArithmeticOperations();

            Console.Write("Enter number 1:");
            double number1 = double.Parse(Console.ReadLine());
            operations.Number1 = number1;

            Console.Write("Enter number 2:");
            double number2 = double.Parse(Console.ReadLine());
            operations.Number2 = number2;

            Console.WriteLine("Summation:" + operations.Summation());
            Console.WriteLine("Subtraction:" + operations.Subtraction());
            Console.WriteLine("Multiplication:" + operations.Multiplication());

            try
            {
                Console.WriteLine("Division:" + operations.Division());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
