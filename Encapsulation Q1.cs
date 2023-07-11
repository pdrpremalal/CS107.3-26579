using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        private static object empDesignation;

        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Enter Employee ID: ");
            int empID = int.Parse(Console.ReadLine());
            employee.EmpiD = empID;

            Console.Write("Enter Employee Name: ");
            string empName = (Console.ReadLine());
            employee.EmpName = empName;

            Console.Write("Enter Employee Designation: ");
            string empdesignation = (Console.ReadLine());
            employee.EmpDesignation = empDesignation;

            //Printing the message with the values retrieved from the getters
            Console.WriteLine("Hello, {0}! Your Employee ID is {1} and you are a {2}.", employee.EmpName, empID, employee.EmpDesignation);
            Console.ReadLine();
        





        }
    }
}
