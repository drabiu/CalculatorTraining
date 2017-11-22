using System;

namespace CalculatorEngine
{
	public class Calculator : ICalculator
    {
		public decimal Add(decimal value, decimal value2)
		{
			return value + value2;
		}

		public decimal Div(decimal value, decimal value2)
		{
			return value / value2;
		}

		public decimal Mul(decimal value, decimal value2)
		{
			return value * value2;
		}

		public decimal Sub(decimal value, decimal value2)
		{
			return value - value2;
		}
	}
}
