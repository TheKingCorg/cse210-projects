
public class Fraction
{
    //Member variables
    private int _top;
    private int _bottom;

    //Constructors
    public Fraction()
    {
        //for use without the user entering a value
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        //For use when the user enters a single value
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        //for use when the user enters both top and bottom values
        _top = top;
        _bottom = bottom;
    }

    // A method that displays the person's job information
    public void ResDisplay()
    {

    }
}