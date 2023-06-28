public class Rechteck
{
    private double _länge;
    private double _breite;

    public double Länge
    {
        get { return _länge; }
        set { _länge = value; }
    }

    public double Breite
    {
        get { return _breite; }
        set { _breite = value; }
    }

   
    public Rechteck()
    {
        _länge = 0;
        _breite = 0;
    }

   
    public Rechteck(double länge, double breite)
    {
        _länge = länge;
        _breite = breite;
    }

    public double Fläche()
    {
        return _länge * _breite;
    }

    public double Umfang()
    {
        return 2 * (_länge + _breite);
    }
}
