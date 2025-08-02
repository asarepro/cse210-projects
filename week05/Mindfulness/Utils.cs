public static class Utils
{
    public static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public static void PauseWithSpinner(int seconds)
    {
        string spinner = @"|/-\";
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % spinner.Length]} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    public static string GetRandomItem(string[] items)
    {
        Random rnd = new Random();
        return items[rnd.Next(items.Length)];
    }
}