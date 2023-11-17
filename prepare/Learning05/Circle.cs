using System;
public abstract class Circle: Shape
{
    // A field for the radius
    private double _radius;

    // A constructor for the circle
    public  Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // An override method for GetArea()
    public override double GetArea()
    {
        // Use the formula for the area of a circle
        return Math.PI * _radius * _radius;
    }
}