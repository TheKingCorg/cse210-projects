public abstract class Shape
{
    //Member variables
    private string _color;

    //Constructors
    public Shape(){
        _color = "undefined";
    }

    //Methods
    public string GetColor(){
        return "";
    }
    public void SetColor(string targColor){
    }
    //Abstract method
    public abstract double GetArea();
}