using System;

namespace CalculatorEngine
{
    public class Calculator2 : CalculatorPanel, ICalculator
    {
        public new decimal Percent(decimal value, decimal value2)
        {
            var result = value / 100 * value2;

            return Math.Round(result, 2);
        }
    }
}
