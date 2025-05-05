namespace MoneyConverter
{
    public class Program
    {
        static void Main()
        {
            byte choice;
            double numberInput;
            bool roundNumber;

            MoneyConvert convert = new MoneyConvert();
            MoneyCourse course = new MoneyCourse();

            Console.Write("***MoneyConverter***\n1. Ruble to USD\n2. USD to Ruble\nEnter your choice: ");
            choice = byte.Parse(Console.ReadLine());

            Console.Write("Round the numbers? y/n: ");
            var roundInput = Console.ReadLine();
            if (roundInput == "y")
                roundNumber = true;
            else if(roundInput == "n")
                roundNumber = false;
            else
                roundNumber = false;

            while (true)
            {
                Console.Write("Enter number: ");
                numberInput = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(convert.ConvertRubleToDollar(numberInput, course.GetRubleCourse(), roundNumber));
                        break;
                    case 2:
                        Console.WriteLine(convert.ConvertDollarToRuble(numberInput, course.GetRubleCourse(), roundNumber));
                        break;
                }
            }
        }
    }
}
