namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that takes an amount - the change that needs to be returned,
            // and calculates how it can be done with the
            // minimum possible number of coins.
            // Input: 1.23
            // Output: 4

            decimal changeToReturn = decimal.Parse(Console.ReadLine());
            decimal changeToWork = changeToReturn;
            int numberCoins = 0;

            decimal collectedSum = 0;

            while (collectedSum < changeToReturn) 
            {
                if (changeToWork >= 2) 
                {
                    collectedSum += 2.0m;
                    changeToWork -= 2.0m;
                }
                else if (changeToWork >= 1) 
                {
                    collectedSum += 1.0m;
                    changeToWork -= 1.0m;
                }
                else if (changeToWork >= 0.5m)
                {
                    collectedSum += 0.5m;
                    changeToWork -= 0.5m;
                }
                else if (changeToWork >= 0.2m)
                {
                    collectedSum += 0.2m;
                    changeToWork -= 0.2m;
                }
                else if (changeToWork >= 0.1m)
                {
                    collectedSum += 0.1m;
                    changeToWork -= 0.1m;
                }
                else if (changeToWork >= 0.05m)
                {
                    collectedSum += 0.05m;
                    changeToWork -= 0.05m;
                }
                else if (changeToWork >= 0.02m)
                {
                    collectedSum += 0.02m;
                    changeToWork -= 0.02m;
                }
                else if (changeToWork >= 0.01m)
                {
                    collectedSum += 0.01m;
                    changeToWork -= 0.01m;
                }

                numberCoins += 1;
            }

            Console.WriteLine(numberCoins);
        }
    }
}