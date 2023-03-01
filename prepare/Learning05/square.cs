using System;

public class Square:Shape{
    private double _oneSide;

    public Square(string color, double side) : base (color)
    {
        _oneSide = side;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _oneSide * _oneSide;
    }
}