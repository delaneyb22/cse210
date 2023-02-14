using System;

class Program
{
    static void Main(string[] args)
    {
        assignment a1=new assignment();
        a1.setName("Samuel Bennett");
        a1.setTopic("Multiplication");

        Console.WriteLine(a1.getSummary());

        mathAssignment m1=new mathAssignment();
        m1.setName("Roberto Rodriguez");
        m1.setTopic("Mixed Numbers");
        m1.setSection("8.1");
        m1.setProblems("10-20");

        Console.WriteLine(m1.getSummary());
        Console.WriteLine(m1.getHomeworkList());

        writingAssignment w1= new writingAssignment();
        w1.setName("Mary Smith");
        w1.setTopic("World History");
        w1.setTitle("The Causes of The Second World War");

        Console.WriteLine(w1.getWritingInformation());
    }
}