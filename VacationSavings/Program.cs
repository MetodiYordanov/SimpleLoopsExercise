namespace VacationSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that checks if user can manage to save required amount of money.
            // Example - Input: needed money = 2000; available money = 1000;
            // commands = spend 1200, save 2000
            // Output: You saved the money for 2 days.

            double neededMoney = int.Parse(Console.ReadLine());
            double availableMoney = int.Parse(Console.ReadLine());

            int numberDays = 0;
            int fiveConsecutiveSpends = 0;
            string previousAction = string.Empty;
            string actionType = Console.ReadLine();

            while (availableMoney < neededMoney) 
            {
                numberDays += 1;
                double sumToAction = double.Parse(Console.ReadLine());
                previousAction = actionType;

                if (actionType == "spend") 
                {
                    fiveConsecutiveSpends += 1;
                    if (previousAction == "spend" && fiveConsecutiveSpends == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(numberDays);
                        return;
                    }
                    availableMoney -= sumToAction;
                    if (availableMoney < 0) 
                    {
                        availableMoney = 0;
                    }
                }
                else if (actionType == "save")
                {
                    availableMoney += sumToAction;
                    if (availableMoney >= neededMoney) 
                    {
                        Console.WriteLine($"You saved the money for {numberDays} days.");
                        return;
                    }
                }

                actionType = Console.ReadLine();
            }
        }
    }
}