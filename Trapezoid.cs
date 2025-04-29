public class Trapezoid
{
    public (double X, double Y) A, B, C, D;

    public Trapezoid()
    {
        Random rnd = new Random();
        A = (rnd.Next(0, 10), rnd.Next(0, 10));
        B = (A.X + rnd.Next(1, 5), A.Y);
        C = (B.X - rnd.Next(1, 3), B.Y + rnd.Next(2, 5));
        D = (A.X + rnd.Next(1, 3), C.Y);
    }

    public double Area()
    {
        double h = Math.Abs(A.Y - C.Y);
        double a = Distance(A, B);
        double b = Distance(C, D);
        return 0.5 * h * (a + b);
    }

    public double Perimeter()
    {
        return Distance(A, B) + Distance(B, C) + Distance(C, D) + Distance(D, A);
    }

    public override string ToString()
    {
        return $"A{A}, B{B}, C{C}, D{D}, S={Area():F2}, P={Perimeter():F2}";
    }

    private double Distance((double X, double Y) p1, (double X, double Y) p2)
    {
        return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
    }
}
