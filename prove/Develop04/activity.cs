using System;

public class activity{
    protected string _name;
    protected string _activityDescription;
    protected int _duration;
    

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
        string startMessage=$"Description that will display at beginning of each activity. NAME: {_name} DESCRIPTION: {_activityDescription} DURATION: {_duration} ";
        return startMessage;
    }
}