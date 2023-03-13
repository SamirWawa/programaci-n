using System.Text.RegularExpressions;
class NumeroCurioso
{
    public double A {get;}
    public double B {get;}
    public double C {get;}
    public NumeroCurioso(string cadena)
    {
        string patron = @"^(?<a>\d+),(?<b>\d+),(?<c>\d+)$";
        Match coincidencia = Regex.Match(cadena, patron);
        if(coincidencia.Success)
        {
            A = double.Parse(coincidencia.Groups["a"].Value);
            B = double.Parse(coincidencia.Groups["b"].Value);
            C = double.Parse(coincidencia.Groups["c"].Value);
        }
        else 
            throw new ArgumentException("Lo has puesto mal");
    }
    public static NumeroCurioso operator +(NumeroCurioso nc1, NumeroCurioso nc2)
    {
        double num1 = default;
        double num2=default;
        double num3=default;
        if(Math.Pow(nc1.A+nc2.A, 2)+Math.Pow(nc1.B+nc2.B, 2)+Math.Pow(nc1.C+nc2.C, 2)!=0)
        {
            num1 = (nc1.A+nc2.A)/Math.Sqrt(Math.Pow(nc1.B+nc2.B, 2)+Math.Pow(nc1.C+nc2.C, 2)+Math.Pow(nc1.A+nc2.A, 2));
            num2 = (nc1.B+nc2.B)/Math.Sqrt(Math.Pow(nc1.B+nc2.B, 2)+Math.Pow(nc1.C+nc2.C, 2)+Math.Pow(nc1.A+nc2.A, 2));
            num3 = (nc1.C+nc2.C)/Math.Sqrt(Math.Pow(nc1.B+nc2.B, 2)+Math.Pow(nc1.C+nc2.C, 2)+Math.Pow(nc1.A+nc2.A, 2));
            return new NumeroCurioso($"{num1},{num2},{num3}");
        }
        else
            return new NumeroCurioso("0,0,0");
    }
    public static NumeroCurioso operator -(NumeroCurioso nc1, NumeroCurioso nc2)
    {
        double num1 = default;
        double num2=default;
        double num3=default;
        if(Math.Pow(nc1.A-nc2.A, 2)+Math.Pow(nc1.B-nc2.B, 2)+Math.Pow(nc1.C-nc2.C, 2)!=0)
        {
            num1 = (nc1.A-nc2.A)/Math.Sqrt(Math.Pow(nc1.B-nc2.B, 2)+Math.Pow(nc1.C-nc2.C, 2)+Math.Pow(nc1.A-nc2.A, 2));
            num2 = (nc1.B-nc2.B)/Math.Sqrt(Math.Pow(nc1.B-nc2.B, 2)+Math.Pow(nc1.C-nc2.C, 2)+Math.Pow(nc1.A-nc2.A, 2));
            num3 = (nc1.C-nc2.C)/Math.Sqrt(Math.Pow(nc1.B-nc2.B, 2)+Math.Pow(nc1.C-nc2.C, 2)+Math.Pow(nc1.A-nc2.A, 2));
            return new NumeroCurioso($"{num1},{num2},{num3}");
        }
        else
            return new NumeroCurioso("0,0,0");
    }
}