using System;

public class scriptureManager{
   public List<string> ScriptureBreaker(string scripture)
   {
        List<string> brokenScripture = new List<string>(scripture.Split(' '));

        foreach (string r in brokenScripture){
            Console.Write(r);
            Console.Write(' ');
        }
        return brokenScripture;
   }
    public List<string> NumberList(List<string> ScriptureList){
            List<int> NumberList=new List<int>();
            int counter=0;

            foreach(string item in ScriptureList){
                counter +=1;
                NumberList.Add(counter);
            }
            foreach(int r in NumberList){
                Console.WriteLine(r);
                
            }
        return ScriptureList;
        }


}