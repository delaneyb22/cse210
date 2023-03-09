using System;

public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }
}