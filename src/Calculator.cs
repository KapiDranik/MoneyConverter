namespace MoneyConverter
{
    class Calculator
    {
        public int _firstNum;
        public int _secondNum;

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
