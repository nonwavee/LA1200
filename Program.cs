using System;

namespace LA1200
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            Random r = new Random();
            int winNum = r.Next(0, 100);
            bool win = false;
            int attempts = 0;
            do
            {
                Console.WriteLine("Guess a number inbetween 0 and 100: ");
                string userinput = Console.ReadLine();

                int input = int.Parse(userinput);

                if (input > winNum)
                {
                    Console.WriteLine("Too high!  Guess lower...");
                    attempts++;
                }
                else if (input < winNum)
                {
                    Console.WriteLine("Too low!  Guess higher...");
                    attempts++;
                }
                else if (input == winNum)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("Your attempts:" + attempts);

                    win = true;
                }

                Console.WriteLine();
            } while (win == false);
            request:
            Console.WriteLine("Do you want to play again? yes/no");

            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                goto Start;
            }
            else if (userInput == "no")
            {
                goto finish;
            }
            else
            {
                goto request;
            }

        finish:
            Console.WriteLine();
            Console.WriteLine("Thanks for playing");
            
        }
    }
}
