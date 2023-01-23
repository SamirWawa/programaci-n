abstract class TablaEnteros
{
    private string cadena;
    private int dimension;
    public TablaEnteros(int dimension)
    {
        this.dimension=dimension;
    }
    protected int[] tabla;
    abstract public void GuardarNumerosEnTabla();
    public string MostrarTabla()
    {
        for(int i=0; i<tabla.Length; i++)
            cadena+=tabla[i];
        return cadena;
    }
    public int SumaPropia()
    {
        int pares=default;
        int paresTotal=default;
        int impares=default;
        int imparesTotal=default;
        foreach(int i in tabla)
            if(i>0)
            {
                pares++;
                paresTotal+=i;
            }
            else
            {
                impares++;
                imparesTotal+=i;
            }
        if(pares>impares)
            return paresTotal;
        else
            return imparesTotal;

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        TablaEnteros impares = new TablaImpares(5);
            impares.GuardarNumerosEnTabla();
            Console.WriteLine("La tabla de Impares es: ");
            impares.MostrarTabla();
            Console.WriteLine("La suma propia de los números es {0}", impares.SumaPropia());

            TablaEnteros pares = new TablaPares(5);
            pares.GuardarNumerosEnTabla();
            Console.WriteLine("La tabla de Pares es: ");
            pares.MostrarTabla();
            Console.WriteLine("La suma propia de los números es {0}", pares.SumaPropia());
    }
}