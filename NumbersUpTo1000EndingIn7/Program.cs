namespace NumbersUpTo1000EndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that prints the numbers in the range from 1 to 1000
            // that end with the digit 7.
            
            for (int i = 7; i <= 997; i += 1)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}