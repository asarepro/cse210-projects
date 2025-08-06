using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
    }

    public void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} - {goals[i].Description}");
        }
    }

    public void ShowScore() => Console.WriteLine($"Total Score: {score}");

    public void Save(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(score);
        foreach (var goal in goals)
        {
            writer.WriteLine(goal.Serialize());
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename)) return;
        goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "Simple":
                    var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) sg.RecordEvent();
                    goals.Add(sg);
                    break;
                case "Eternal":
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "Checklist":
                    var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
                    for (int j = 0; j < int.Parse(parts[5]); j++) cg.RecordEvent();
                    goals.Add(cg);
                    break;
            }
        }
    }
}