namespace CalculatorLib
{
    public class Calculator
    {
        public int Addition(int a, int b)
        {
            return a+b;
        }

        public async Task<int> Substraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
