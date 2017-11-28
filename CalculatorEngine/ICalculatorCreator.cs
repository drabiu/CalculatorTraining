namespace CalculatorEngine
{
    public interface ICalculatorCreator
    {
        ICalculator CreateCalculator(string type);
    }
}
