namespace CalculatorEngine
{
    public class CalculatorCreator : ICalculatorCreator
    {
        public ICalculator CreateCalculator(string type)
        {
            ICalculator calculator = null;
            if (type == "Calculator")
            {
                calculator = new Calculator();
            }
            else if (type == "Calculator2")
            {
                calculator = new Calculator2();
            }
            else if (type == "CalculatorSci")
            {
                calculator = new CalculatorSci();
            }

            return calculator;
        }
    }
}
