using FizzBuzzCalculator;
using System;

namespace FizzBuzz
{
    class Program
	{
		static void Main(string[] args)
		{
			FizzBuzzCalc calc = new FizzBuzzCalc();
			for (int i = 1; i <= 100; i++)
			{
				string toPrint = calc.ToString(i);
				Console.Out.WriteLine(toPrint);
			}
		}
	}
}
