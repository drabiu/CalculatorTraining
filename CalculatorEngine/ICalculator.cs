namespace CalculatorEngine
{
	public interface ICalculator
	{
		decimal Add(decimal value, decimal value2);
		decimal Sub(decimal value, decimal value2);
		decimal Div(decimal value, decimal value2);
		decimal Mul(decimal value, decimal value2);
        decimal Percent(decimal value, decimal value2);
	}
}
