using CalculatorEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorConsole
{
	class Program
	{
		static void Main(string[] args)
		{
            List<string> commands = new List<string>() { string.Empty };

            Console.WriteLine("Podaj typ kalkulatora:");
            string enteredType = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Podaj działanie(ostatnie - {0}):", commands.Last());
                string enteredLine = Console.ReadLine();
                commands.Add(enteredLine);
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
