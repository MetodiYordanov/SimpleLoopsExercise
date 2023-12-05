namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program where user solves exam problems until he receives the message "Enough".
            // Example - Input: number of acceptable poor grades = 3
            // input data = Money 6, Story 4, Spring Time 5, Bus 6, Enough
            // Output: Average score: 5.25; Number of problems: 4, Last problem: Bus

            int numberPoorGrades = int.Parse(Console.ReadLine());
            int actualPoorGrades = 0;
            string lastProblemName = string.Empty;
            int numberProblems = 0;
            int sumAllGrades = 0;

            string problemName = Console.ReadLine();
            while (problemName != "Enough") 
            {
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4) 
                {
                    actualPoorGrades += 1;
                    if (actualPoorGrades == numberPoorGrades) 
                    {
                        Console.WriteLine($"You need a break, {numberPoorGrades} poor grades.");
                        return;
                    }
                }

                numberProblems += 1;
                lastProblemName = problemName;
                sumAllGrades += grade;

                problemName = Console.ReadLine();
            }

            double averageScore = (double)sumAllGrades / numberProblems;

            Console.WriteLine($"Average score: {averageScore:F2}");
            Console.WriteLine($"Number of problems: {numberProblems}");
            Console.WriteLine($"Last problem: {lastProblemName}");
        }
    }
}