using System;

public class writingAssignment:assignment{

    private string _title;

    public string getTitle(){
        return _title;
    }
    public void setTitle(string title){
        _title=title;
    }

    public string getWritingInformation(){
        return $"{_studentName}-{_topic} {_title}";
    }


}