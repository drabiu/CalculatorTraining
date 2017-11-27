namespace CalculatorEngine
{
    public class OperationManager : IOperationManager
    {
        private decimal _enteredValue;
        private decimal _enteredSecondValue;
        private ICalculator _calculator; 

        public OperationManager(decimal enteredValue, decimal enteredSecondValue)
        {
            _enteredValue = enteredValue;
            _enteredSecondValue = enteredSecondValue;
            _calculator = new Calculator2();
        }

        public decimal ExecuteOperation(string operation)
        {
            decimal result = 0;
            if (operation == "+")
            {
                result = _calculator.Add(_enteredValue, _enteredSecondValue);
            }
            else if (operation == "-")
            {
                result = _calculator.Sub(_enteredValue, _enteredSecondValue);
            }
            else if (operation == "/")
            {
                result = _calculator.Div(_enteredValue, _enteredSecondValue);
            }
            else if (operation == "*")
            {
                result = _calculator.Mul(_enteredValue, _enteredSecondValue);
            }
            else if (operation == "%")
            {
                result = _calculator.Percent(_enteredValue, _enteredSecondValue);
            }

            return result;
        }      
    }
}
