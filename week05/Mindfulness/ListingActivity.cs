public class ListingActivity : Activity
{
    private string[] Prompts = {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity helps you list positives in your life.";
    }

    public override void Run()
    {
        Start();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(Utils.GetRandomItem(Prompts));
        Utils.Countdown(3);

        Console.WriteLine("\nStart listing items:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        End();
    }
}