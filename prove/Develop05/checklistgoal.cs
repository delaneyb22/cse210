using System;


public class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int TimesNeeded { get; set; }
    public int BonusPoints { get; set; }

    public override int AddRecord()
    {
        TimesCompleted++;
        int totalPoints = Points;

        if (TimesCompleted == TimesNeeded)
        {
            Completed = true;
            totalPoints += BonusPoints;
        }

        return totalPoints;
    }
}