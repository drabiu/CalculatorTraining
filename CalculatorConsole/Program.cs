using CalculatorEngine;
using System;

namespace CalculatorConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj pierwszą liczbę:");
			decimal enteredValue = decimal.Parse(Console.ReadLine());
			Console.WriteLine("Podaj znak działania:");
			string enteredOperation = Console.ReadLine();
			Console.WriteLine("Podaj drugą liczbę:");
			decimal enteredSecondValue = decimal.Parse(Console.ReadLine());
			decimal result = 0;

			ICalculator calc = new Calculator();
			if (enteredOperation == "+")
			{
				result = calc.Add(enteredValue, enteredSecondValue);
			}
			else if (enteredOperation == "-")
			{
				result = calc.Sub(enteredValue, enteredSecondValue);
			}
			else if (enteredOperation == "/")
			{
				result = calc.Div(enteredValue, enteredSecondValue);
			}
			else if (enteredOperation == "*")
			{
				result = calc.Mul(enteredValue, enteredSecondValue);
			}
            else if (enteredOperation == "%")
            {
                result = calc.Percent(enteredValue, enteredSecondValue);
            }

			Console.WriteLine("=");
			Console.WriteLine(result);

			Console.ReadLine();
		}
	}
}
