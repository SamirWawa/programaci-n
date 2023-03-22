static class Comparador<T> where T : IComparable
{
    public static bool Mayor(T dato, T dato2)
    {
        if (dato.CompareTo(dato2) > 0)
            return true;
        else
            return false;
    }
    public static bool Menor(T dato, T dato2)
    {
        if (dato.CompareTo(dato2) < 0)
            return true;
        else
            return false;
    }
}