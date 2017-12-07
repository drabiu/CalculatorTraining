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

            while (true)
            {
                Console.WriteLine("Podaj działanie:");
                string enteredLine = Console.ReadLine();
                if (enteredLine == "quit")
                    break;

                char operation = SignConverter.FindOperationInText(enteredLine);
                string[] values = enteredLine.Split(operation);

                decimal enteredValue = int.Parse(values[0]);
                string enteredOperation = operation.ToString();
                decimal enteredSecondValue = int.Parse(values[1]);

                decimal result = 0;
                ICalculatorCreator calculatorCreator = new CalculatorCreator();
                ICalculator calculator = calculatorCreator.CreateCalculator(enteredType);

                IOperationManager operationManager = new OperationManager(enteredValue, enteredSecondValue, calculator);
                result = operationManager.ExecuteOperation(enteredOperation);

                Console.WriteLine("=");
                Console.WriteLine(result);
            }
        }     
    }
}
