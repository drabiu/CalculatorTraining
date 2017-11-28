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

            Console.WriteLine("Ile razy liczyć?");
            int times = int.Parse(Console.ReadLine());

            //for (int counter = 0; counter < times ; counter++)
            //{           
            //}

            while (times > 0)
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                decimal enteredValue = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Podaj znak działania:");
                string enteredOperation = Console.ReadLine();

                Console.WriteLine("Podaj drugą liczbę:");
                decimal enteredSecondValue = decimal.Parse(Console.ReadLine());

                decimal result = 0;
                ICalculatorCreator calculatorCreator = new CalculatorCreator();
                ICalculator calculator = calculatorCreator.CreateCalculator(enteredType);

                IOperationManager operationManager = new OperationManager(enteredValue, enteredSecondValue, calculator);
                result = operationManager.ExecuteOperation(enteredOperation);

                Console.WriteLine("=");
                Console.WriteLine(result);

                Console.ReadLine();

                times--;
            }
		}
	}
}
