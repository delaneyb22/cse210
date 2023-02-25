using System;

public class Activity{
    protected string _name;
    protected string _activityDescription;
    protected int _duration;

    protected string _startMessage;
    

    public string getName(){
       return _name;
    }
    public string getActivityDescription(){
       return _activityDescription;
    }
    public int getDuration(){
       return _duration;
    }
    
    public void setName(string name){
        _name=name;
    }
    
     public void setActivityDescription(string activityDescription){
        _activityDescription=activityDescription;
    }
    public void setDuration(int duration){
        _duration=duration;
    }

    public string getStartMessage(){
        return _startMessage;
    }
    public void setStartMessage(string startMessage){
        _startMessage=startMessage;
    }
}