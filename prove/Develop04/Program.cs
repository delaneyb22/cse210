using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Breathing Activity");
        Console.WriteLine("2.Reflection Activity");
        Console.WriteLine("Listing Activity");
        Menu MainMenu= new Menu();
        
        
    }
}
public class Menu{
    public int _menuOption;
     public int getMenuOption(){
       return _menuOption;
    }
    public void setMenuOption(int menuOption){
        _menuOption=menuOption;
    }

}