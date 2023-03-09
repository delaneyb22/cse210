using System;


public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override void RecordEvent()
    {
        Points += Points;
    }
}
