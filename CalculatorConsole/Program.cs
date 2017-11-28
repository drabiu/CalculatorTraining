using CalculatorEngine;
using System;

namespace CalculatorConsole
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Podaj typ kalkulatora:");
            string enteredType = Console.ReadLine();

            Console.WriteLine("Podaj pierwszą liczbę:");
			decimal enteredValue = decimal.Parse(Console.ReadLine());

			Console.WriteLine("Podaj znak działania:");
			string enteredOperation = Console.ReadLine();

			Console.WriteLine("Podaj drugą liczbę:");
			decimal enteredSecondValue = decimal.Parse(Console.ReadLine());

            decimal result = 0;
            if (enteredType == "Calculator")
            {
                IOperationManager operationManager = new OperationManager(enteredValue, enteredSecondValue, new Calculator());
                result = operationManager.ExecuteOperation(enteredOperation);
            }
            else if (enteredType == "Calculator2")
            {
                IOperationManager operationManager = new OperationManager(enteredValue, enteredSecondValue, new Calculator2());
                result = operationManager.ExecuteOperation(enteredOperation);
            }
            else if (enteredType == "CalculatorSci")
            {
                IOperationManager operationManager = new OperationManager(enteredValue, enteredSecondValue, new CalculatorSci());
                result = operationManager.ExecuteOperation(enteredOperation);
            }

            Console.WriteLine("=");
			Console.WriteLine(result);

			Console.ReadLine();
		}
	}
}
