using System;

public class assignment{

    protected string _studentName;
    protected string _topic;

    public string getName(){
        return _studentName;
    }
    public string getTopic(){
        return _topic;
    }

    public void setName(string name){
        _studentName=name;
    }
    public void setTopic(string topic){
        _topic=topic;
    }


    public string getSummary(){
        return $"{_studentName} - {_topic}";
    }
}