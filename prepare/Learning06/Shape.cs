public abstract class Shape
{
    //Member variables
    private string _color;


    //Constructors
    public Shape(){
        //handles no arguments
        _color = "undefined";
    }
    public Shape(string setColor){
        //handles color passed in as an argument
        _color = setColor;
    }


    //Methods
    public string GetColor(){
        //returns the class's _color variable
        return _color;
    }
    public void SetColor(string targColor){
        _color = targColor;
    }

    //Abstract method
    public abstract double GetArea();
}