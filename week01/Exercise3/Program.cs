using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {

        // Random number generat

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);

        int guess = -1;

        // while loop
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    
        
        
    }
}