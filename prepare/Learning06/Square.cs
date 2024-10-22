public class Square : Shape
{
    //Member variables 
    private double _side;

    //Constructors
    public Square(string color, double length) : base(color){
        //handles no arguments passed in
        _side = length;
    }

    //Methods 
    public override double GetArea(){
        return (_side * _side);
    }
}