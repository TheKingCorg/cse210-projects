
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


    //Methods
    public int GetTop() //returns the value of a stored fraction's numerator
    {
        return _top;
    }
    public void SetTop(int top) //Sets the stored fraction's numerator
    {
        _top = top;
    }
    public int GetBottom() //returns the value of a stored fraction's denominator
    {
        return _bottom;
    }
    public void SetBottom(int bottom) //sets the stored fraction's numerator
    {
        _bottom = bottom;
    }
    public string GetFractionString () //returns the fraction as a x/y string
    {
        return (_top + "/" + _bottom);
    }
    public double GetDecimalValue() //returns the fraction as a decimal
    {
        double var = (_top / _bottom);
        return var;
    }
}