using System;

namespace CalculatorEngine
{
    public class CalculatorSci : CalculatorPanel, ICalculatorSci
    {
        public decimal Pow(decimal value, decimal value2)
        {
            return (decimal)Math.Pow((double)value, (double)value2);
        }
    }
}
