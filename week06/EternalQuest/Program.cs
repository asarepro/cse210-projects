// using System;

//  class Program
//  {
//      static void Main(string[] args)
//      {
//          // Console.WriteLine("Hello World! This is the EternalQuest Project.");
//      }
//  }

using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.ShowGoals();
                    Console.Write("Enter goal number to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case "3":
                    manager.ShowGoals();
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    manager.Save("goals.txt");
                    Console.WriteLine("Goals saved.");
                    break;
                case "6":
                    manager.Load("goals.txt");
                    Console.WriteLine("Goals loaded.");
                    break;
                case "7":
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }
}