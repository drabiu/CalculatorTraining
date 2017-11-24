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

            IOperationManager operationManager = new OperationManager(enteredValue, enteredSecondValue);
            result = operationManager.ExecuteOperation(enteredOperation);

			Console.WriteLine("=");
			Console.WriteLine(result);

			Console.ReadLine();
		}
	}
}
