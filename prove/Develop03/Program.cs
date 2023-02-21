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
       // Console.Write("example of scritpure");
       // Console.ReadLine();
        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine(reference);
        Console.WriteLine("press enter to hide random words until you have the scripture memorized. Or type quit to end program.");
        
        string userValue;
        do
        {
            Console.WriteLine(scripture+ reference);
            Console.WriteLine("Whatever you type(needs to change to ), You will get same Output");
            userValue = Console.ReadLine();
            Console.WriteLine("Your written Words Are: " + userValue);
        }
        while(userValue != "quit");
        



    

       
    }

}