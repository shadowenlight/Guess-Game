using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int target = random.Next(1, 101);

            int guessCount = 0;
            bool found = false;

            while (!found)
            {
                Console.WriteLine("Guess a number between 1 and 100\n");
                int guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess > target)
                    Console.WriteLine("Target is lower!");
                else if (guess < target)
                    Console.WriteLine("Target is higher!");
                else
                {
                    Console.WriteLine("Found the target on the "+guessCount+". try!!!");
                    found = true;
                }

            }

        }
    }
}