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

                char operation = FindOperationInText(enteredLine);
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

        public static bool CheckIfSignIsNumber(char sign)
        {
            bool result = false;
            char[] digits = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (char digit in digits)
            {
                if(sign == digit)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public static char FindOperationInText(string text)
        {
            char result = ' ';
            foreach (char sign in text)
            {
                bool isNumber = CheckIfSignIsNumber(sign);
                if (!isNumber)
                {
                    result = sign;
                    break;
                }
            }

            return result;
        }
	}
}
