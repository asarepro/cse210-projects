public class ReflectionActivity : Activity
{
    private string[] Prompts = {
        "Think of a time when you stood up for someone.",
        "Think of a time you helped someone in need.",
        "Think of a time you did something truly selfless."
    };

    private string[] Questions = {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you feel afterwards?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection";
        Description = "This activity helps you reflect on times you’ve shown strength and resilience.";
    }

    public override void Run()
    {
        Start();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(Utils.GetRandomItem(Prompts));
        Utils.PauseWithSpinner(3);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine(Utils.GetRandomItem(Questions));
            Utils.PauseWithSpinner(4);
            elapsed += 4;
        }

        End();
    }
}