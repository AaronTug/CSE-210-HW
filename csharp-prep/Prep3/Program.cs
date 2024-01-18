using System;

class Program
{
    static void Main(string[] args)
    {
        //define variables
        int guess = -1;
        int random;
        //get random number
        Random randomgenerator = new Random();
        random = randomgenerator.Next(1, 101);
        do
        {
            //ask for user to guess
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());
            //if higher
            if (guess > random)
            {
                Console.WriteLine("Your Guess is to High");
            }

            //if lower
            else if (guess < random)
            {
                Console.WriteLine("Your Guess is to Low");
            }

            //if correct
            else
            {
                Console.WriteLine("You Got It!!");
            }
        } while (guess != random);
    }
}