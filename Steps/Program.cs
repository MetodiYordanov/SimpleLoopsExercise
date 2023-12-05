namespace Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that reads from the console how many steps user
            // takes each time he goes out during the day.
            // Input: 1000, 1500, 2000, 6500
            // Output: Goal reached! Good job! 1000 steps over the goal!

            const int stepsToWalk = 10000;

            int stepsWalked = 0;
            bool isGoingHome = false;

            string steps = Console.ReadLine();

            while (stepsWalked < stepsToWalk) 
            {
                int stepsAsNum = 0;
                if (steps != "Going home")
                {
                    stepsAsNum = int.Parse(steps);
                }
                else
                {
                    isGoingHome = true;
                    steps = Console.ReadLine();
                    continue;
                }
                stepsWalked += stepsAsNum;

                if (isGoingHome == true)
                {
                    int diff = 0;
                    if (stepsWalked >= stepsToWalk)
                    {
                        diff = stepsWalked - stepsToWalk;
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{diff} steps over the goal!");
                    }
                    else
                    {
                        diff = stepsToWalk - stepsWalked;
                        Console.WriteLine($"{diff} more steps to reach goal.");
                    }
                    return;
                }
                else if (stepsWalked >= stepsToWalk)
                {
                    int diff = stepsWalked - stepsToWalk;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{diff} steps over the goal!");
                    break;
                }

                steps = Console.ReadLine();
            }

            
        }
    }
}