using System.Formats.Asn1;

public class Square : Shape
{
    //Member variables 
    private double _side;

    //Constructors
        public Square(double length) : base(){
        //handles no color argument
        _side = length;
    }
    public Square(string color, double length) : base(color){
        //handles color argument
        _side = length;
    }

    //Methods 
    public override double GetArea(){
        double area = (_side * _side);
        double shortArea = Math.Round(area, 2);
        return shortArea;
    }
}