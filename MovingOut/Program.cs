namespace MovingOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that calculates the free volume of user's apartment
            // after he moves his luggage. One box has exact dimensions: 1m x 1m x 1m
            // Input: width = 10, length = 10, height = 2,
            // number of boxes = 20, 20, 20, 20, 122
            // Output: No more free space! You need 2 Cubic meters more.

            int widthSpace = int.Parse(Console.ReadLine());
            int lengthSpace = int.Parse(Console.ReadLine());
            int heightSpace = int.Parse(Console.ReadLine());

            int freeSpace = widthSpace * lengthSpace * heightSpace;

            string command = Console.ReadLine();

            while (command != "Done") 
            {
                int commandAsNum = int.Parse(command);

                if (freeSpace >= commandAsNum) 
                {
                    freeSpace -= commandAsNum;
                }
                else
                {
                    int diff = commandAsNum - freeSpace;
                    Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{freeSpace} Cubic meters left.");
        }
    }
}