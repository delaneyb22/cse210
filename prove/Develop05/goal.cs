using System;


public class Goal
{
    private string name;
    private string description;
    private int points;

    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public int Points { get => points; set => points = value; }

    public virtual void RecordEvent() { }
}