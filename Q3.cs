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
            Console.Write("Enter km value:");
            double km = double.Parse(Console.ReadLine());

            ConvertValues obj = new ConvertValues();
            double m = obj.kilometerTOmeter(km);

            Console.Write(m.ToString());

            Console.ReadKey();
        }
    }
}
