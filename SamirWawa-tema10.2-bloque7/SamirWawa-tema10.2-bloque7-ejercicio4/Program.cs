using System.Text.RegularExpressions;
class Polinomio : IEnumerable<SortedDictionary<int, int>>
{
    private SortedDictionary<int, int> Monomios { get; set; }
    public Polinomio(string monomio)
    {
        Monomios = new SortedDictionary<int, int>();
        string patron = @"(?<grupoCoeficiente>[+-]?\d*)?(?<grupoIncognita>[Xx])?(?<grupoExponente>\d*)?";
        string cadena = ""; /*O split o iterar por matches usando NextMatch()*/
        for (int i = 0; i < monomio.Length; i++)
        {
            if (monomio[i + 1] == '+' || monomio[i + 1] == '-' || i == monomio.Length - 1)
            {
                Match coincidencia = Regex.Match(cadena, patron);
                string c = coincidencia.Groups["grupoCoeficiente"].Value;
                string e = coincidencia.Groups["grupoExponente"].Value;
                string inc = coincidencia.Groups["grupoIncognita"].Value;
                if (c == "")
                    c = "0";
                if (e == "")
                    e = "1";
                if (inc == "")
                    e = "0";
                Monomios.Add(int.Parse(e), int.Parse(c));
                cadena = "";
            }
            cadena += monomio[i];
        }
    }
    public IEnumerator<SortedDictionary<int, int>> GetEnumerator() => Monomios.GetEnumerator();
    System.Collections.IEnumerator
    System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    public static Polinomio Suma(Polinomio p1, Polinomio p2)
    {
        foreach (SortedDictionary<int, int> i in p2)
        {
            if (p1.Monomios.ContainsKey(i[0]))
            {

            }
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Polinomio p = new Polinomio("9x7-3x5-7x-5");
    }
}
