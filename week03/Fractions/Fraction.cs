public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop(int top)
    {
        _top = top;
    }

    public void GetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int SetTop()
    {
        int export = _top;
        return export;
    }

    public int SetBottom()
    {
        int export = _bottom;
        return export;
    }

    public string GetFractionalString()
    {
        string stringFraction = $"{_top}/{_bottom}";
        return stringFraction;
    }

    public double GetDecimalValue()
    {
        
        double decimalValue = (double)_top/_bottom;
        return decimalValue;
    }
}