using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their names

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");

        // ===============


    }
}