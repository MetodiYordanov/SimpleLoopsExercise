namespace BirthdayCake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that calculates the number of pieces guests have taken
            // before the cake runs out.
            // Input: length = 10, width = 2, number of pieces =  2, 4, 6, STOP
            // Output: 8 pieces are left

            int widthCake = int.Parse(Console.ReadLine());
            int lengthCake = int.Parse(Console.ReadLine());
            int numberPieces = widthCake * lengthCake;

            string pieceCake = Console.ReadLine();
            while (pieceCake != "STOP") 
            {
                int pieceCakeAsNum = int.Parse(pieceCake);

                if (numberPieces >= pieceCakeAsNum)
                {
                    numberPieces -= pieceCakeAsNum;
                }
                else
                {
                    int diff = pieceCakeAsNum - numberPieces;
                    Console.WriteLine($"No more cake left! You need {diff} pieces more.");
                    return;
                }

                pieceCake = Console.ReadLine();
            }

            Console.WriteLine($"{numberPieces} pieces are left.");
        }
    }
}