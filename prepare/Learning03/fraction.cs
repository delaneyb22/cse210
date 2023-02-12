using System;

public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top=1;
        _bottom=1;
    }
    public Fraction(int wholeNumber){
        _top=wholeNumber;
        _bottom=1;
    }
    public Fraction(int top,int bottom){
        _top=top;
        _bottom=bottom;
    }
    public int GetTopValue(){
        return _top;
    }
    public int GetBottomValue(){
        return _bottom;
    }
    public void SetTopValue(int top){
        _top=top; 
    }
    public void SetBottomValue(int bottom){
        _bottom=bottom;
    }
    public string GetFractionString(){
       string message=$"{_top}/{_bottom}";
       return message;
    }
    public double GetDecimalValue(){
       // double answer =_top/_bottom;
        //return answer;
        return (double)_top / (double)_bottom;
    }
}