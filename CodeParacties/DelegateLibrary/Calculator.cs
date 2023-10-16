namespace DelegateLib
{
    public delegate int MathsAddDelegate(int number1, int number2);

    public class Calculator
    {
        private readonly MathsAddDelegate _calculatorDelegate;

        public Calculator(MathsAddDelegate delegateReference)
        {
            _calculatorDelegate = delegateReference;
        }

        public int Add(int aintNumber1, int aintNumber2)
        {
            return _calculatorDelegate.Invoke(aintNumber1, aintNumber2);
        }
    }
}