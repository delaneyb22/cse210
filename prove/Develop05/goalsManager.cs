using System;
public class ChecklistGoal : Goal
{
    private int totalEvents;
    private int targetEvents;

    public ChecklistGoal(string name, string description, int points, int targetEvents)
    {
        Name = name;
        Description = description;
        Points = points;
        totalEvents = 0;
        this.targetEvents = targetEvents;
    }

    public override void RecordEvent()
    {
        totalEvents++;
        Points += Points;
        if (totalEvents == targetEvents)
        {
            Points += 500;
        }
    }
}