namespace MoneyConverter
{
    public class MoneyConvert
    {
        double result;
        Calculator calc = new Calculator();

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
