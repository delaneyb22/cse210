using System;

class Program
{
    static void Main(string[] args)
    {
       //scriptureManager s1=new scriptureManager();
       //word w=new word();
       Console.Write("please enter scripture reference: ");
       string reference = Console.ReadLine();
       Console.WriteLine("please enter scripture text ");
       string scripture=Console.ReadLine();
       scriptureManager brkScrpt = new scriptureManager();
       List<string> brokenScripture = brkScrpt.ScriptureBreaker(scripture);


       
    }

}