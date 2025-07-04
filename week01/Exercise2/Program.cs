using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade percentage ");
        string answer = Console.ReadLine();

        int percent = int.Parse(answer);

        string letter = "none";


        if (percent >= 90)
        {
            letter = "A";
            // Console.WriteLine($"{letter}");
        }

        else if (percent >= 80)
        {
            letter = "B";
            Console.WriteLine(letter);
        }

        else if (percent >= 70)
        {
            letter = "C";
            // Console.WriteLine(letter);
        }

        else if (percent >= 60)
        {
            letter = "D";
            // Console.WriteLine(letter);
        }

        else
        {
            letter = "F";
            // Console.WriteLine(letter);
        }

        if (percent >= 70)
        {
            Console.WriteLine("Congratulation you pass, you do well.");
        }

        else
        {
            Console.WriteLine("You can do well next time never give up.");
        }

        //    Last digits for the + / -
        int lastdigit = percent % 10;

        string sign = "";

        if (lastdigit >= 7)
        {
            sign = "+";
        }

        else if (lastdigit < 3)
        {
            sign = "-";
        }

        if (percent >= 93)
        {
            sign = "";
        }

        else if (percent < 70)
        {
            sign = "";
        }

         Console.WriteLine($"{letter}{sign}");






        
       
    }
}