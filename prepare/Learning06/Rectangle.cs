using System.Formats.Asn1;

public class Rectangle : Shape
{
    //member variables
    private double _length;
    private double _width;

    //Constructors
    public Rectangle(double length, double width) : base(){
        //in case no color arg is declared
        _length = length;
        _width = width;
    }
    public Rectangle(string color, double length, double width) : base(color){
        //uses a passed in "color"
        _length = length;
        _width = width;
    }

    //methods
    public override double GetArea()
    {
        double area = (_length * _width);
        double shortArea = Math.Round(area, 2);
        return shortArea;
    }
}