namespace MoneyConverter
{
    public class Program
    {
        static void Main()
        {
            byte choice = 0;
            double numberInput;
            bool roundNumber = false;
            bool endSettingsCycle = true;

            MoneyConvert convert = new MoneyConvert();
            MoneyCourse course = new MoneyCourse();

            Console.Write("***MoneyConverter***\n1. Ruble to USD\n2. USD to Ruble\n\n");

            // Settings window
            while (endSettingsCycle)
            {
                try
                {
                    Console.Write("Enter your choice (1 or 2): ");
                    choice = byte.Parse(Console.ReadLine());

                    Console.Write("Round the numbers? y/n: ");
                    var roundInput = Console.ReadLine();
                    if (roundInput == "y")
                        roundNumber = true;
                    else if (roundInput == "n")
                        roundNumber = false;
                    else
                        roundNumber = false;
                    endSettingsCycle = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not the right format! Please enter the number.");
                }
            }

            //Convert window
            while (true)
            {
                try
                {
                    Console.Write("Enter number: ");
                    numberInput = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Result: " + convert.ConvertRubleToDollar(numberInput, course.GetRubleCourse(), roundNumber));
                            break;
                        case 2:
                            Console.WriteLine("Result: " + convert.ConvertDollarToRuble(numberInput, course.GetRubleCourse(), roundNumber));
                            break;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Not the right format! Please enter the number.");
                }
            }
        }
    }
}
