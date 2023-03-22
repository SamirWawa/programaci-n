class Persona: IComparable<Persona>, ICloneable
{
    public int Edad{get;set;}
    public string Nombre{get;set;}
    public Persona(int edad, string nombre){}
    public int CompareTo(Persona p)
    {
        return Edad-p.Edad;
    }
    public Object Clone()
    {
        return new Persona(Edad, Nombre);
    }
    public override string ToString()
    {
        return $"{Nombre} {Edad}";
    }
    public static bool Mayor(Persona dato, Persona dato2)
    {
        if (dato.CompareTo(dato2) > 0)
            return true;
        else
            return false;
    }
    public static bool Menor(Persona dato, Persona dato2)
    {
        if (dato.CompareTo(dato2) < 0)
            return true;
        else
            return false;
    }
}