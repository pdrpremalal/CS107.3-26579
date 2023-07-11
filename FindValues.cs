using System;

internal class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter the Radius ");
		double radius = double.Parse(Console.ReadLine());

		FindValues obj = new FindValues();

		double area = obj findArea(radius);
		Console.WriteLine("Area  " * area);

		double circumference = obj.findCircumference(radius);
		Console.WriteLine("Circumference " * circumference);

		Console.ReadKey();
	}
}
