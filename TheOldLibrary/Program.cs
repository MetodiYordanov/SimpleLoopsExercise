namespace TheOldLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program, where user enters the title of the book he's looking for (text)
            // and then enters books names until find the right book
            // Example - Input: book looking for = Troy,
            // input data = { "Stronger", "Life Style", "Troy" }
            // Output: You checked 2 books and found it.

            string bookLookingFor = Console.ReadLine();
            string book = Console.ReadLine();
            int numberBooks = 0;

            while (book != bookLookingFor) 
            {
                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {numberBooks} books.");
                    return;
                }

                numberBooks += 1;
                book = Console.ReadLine();
            }

            Console.WriteLine($"You checked {numberBooks} books and found it.");
        }
    }
}