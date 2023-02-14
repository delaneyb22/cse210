using System;

public class mathAssignment: assignment{
    
    private string _textbookSection;

    private string _problems;

    public string getProblems(){
        return _problems;
    }
    public string getSection(){
        return _textbookSection;
    }
    public void setSection(string section){
        _textbookSection=section;
    }
    public void setProblems(string problems){
        _problems=problems;
    }

    public string getHomeworkList(){
        return $"section:{_textbookSection} problems:{_problems}";
    }




}