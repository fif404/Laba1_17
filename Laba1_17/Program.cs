// Скрипников Сергей 17 вариант 22-ИСП-2.1
abstract class Norm
{
    public virtual double NormValue()
    {
        return Math.Sqrt(ModulusValue());
    }

    public virtual double ModulusValue()
    {
        return 0;
    }
}

class Complex : Norm
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override double NormValue()
    {
        return Real * Real + Imaginary * Imaginary;
    }

    public override double ModulusValue()
    {
        return NormValue();
    }
}

class Vector3D : Norm
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override double ModulusValue()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public override double NormValue()
    {
        return Math.Max(Math.Abs(X), Math.Max(Math.Abs(Y), Math.Abs(Z)));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex c = new Complex(1, 2);
        Vector3D v = new Vector3D(3, 4, 5);

        Console.WriteLine("Норма комплексного числа: {0}", c.NormValue());
        Console.WriteLine("Модуль комплексного числа: {0}", c.ModulusValue());
        Console.WriteLine("Норма вектора: {0}", v.NormValue());
        Console.WriteLine("Модуль вектора: {0}", v.ModulusValue());

        Console.ReadKey();
    }
}