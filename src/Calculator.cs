namespace MoneyConverter
{
    class Calculator
    {
        public double Calculate(double firstNumber, char oper, double secondNumber)
        {
            switch (oper)
            {
                case '+':
                    return firstNumber + secondNumber;
                case '-':
                    return firstNumber - secondNumber;
                case '*':
                    return firstNumber * secondNumber;
                case '/':
                    return firstNumber / secondNumber;
                case '%':
                    return firstNumber % secondNumber;
                default:
                    return 0;
            }
        }
    }
}
