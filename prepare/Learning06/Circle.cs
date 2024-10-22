public class Circle : Shape
{
    //member variables 
    private double _radius;

    //Constructor
    public Circle(double length) : base(){
        //in case no color arg is passed in
        _radius = length;
    }
    public Circle(string color, double length) : base(color){
        //handles a color arg
        _radius = length;
    }

    //methods
    public override double GetArea()
    {
        return ((Math.PI) * _radius * _radius);
    }
}