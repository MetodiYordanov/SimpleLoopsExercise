namespace ElementThatEqualsToTheSumOfOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that reads n integer numbers entered by the user, and checks whether there is a number among them that is equal to the sum of all the others.
            // Example - Input: number of integers = 4, input data = 6, 1, 2, 3
            // Output: Yes, Sum = 6

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++) 
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            int sumWithoutMaxNumber = sum - max;
            if (max == sumWithoutMaxNumber) 
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}