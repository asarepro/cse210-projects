public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by guiding you through slow, deep breathing.";
    }

    public override void Run()
    {
        Start();

        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Utils.Countdown(4);
            elapsed += 4;

            Console.WriteLine("Breathe out...");
            Utils.Countdown(6);
            elapsed += 6;
        }

        End();
    }
}