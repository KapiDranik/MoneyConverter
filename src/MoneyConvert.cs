namespace MoneyConverter
{
    public class MoneyConvert
    {
        Calculator calc = new Calculator();
        double result;

        public double ConvertDollarToRuble(double numberInDollars, double currentCourse, bool roundResult)
        {
            result = calc.Calculate(numberInDollars, '*', currentCourse);
            if (roundResult)
                return Math.Round(result);
            else
                return result;
        }

        public double ConvertRubleToDollar(double numberInRubles, double currentCourse, bool roundResult)
        {
            result = calc.Calculate(numberInRubles, '/', currentCourse);
            if (roundResult)
                return Math.Round(result);
            else
                return result;
        }
    }
}
