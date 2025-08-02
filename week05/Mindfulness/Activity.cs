public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine($"{Description}\n");
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Utils.PauseWithSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nGood job!");
        Utils.PauseWithSpinner(2);
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Utils.PauseWithSpinner(2);
    }

    public abstract void Run();
}