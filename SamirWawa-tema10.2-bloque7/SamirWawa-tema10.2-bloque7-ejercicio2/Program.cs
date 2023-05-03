internal class Program
{
    private static void AñadeAutomovil(List<Automovil> l1, Automovil a)
    {
        l1.Add(a);
    }
    private static void EliminaAutomovil(List<Automovil> l1, int i)
    {
        l1.RemoveAt(i);
    }
    private static List<Automovil> AutomovilPorAñoDeFabricacion(List<Automovil> l1, int año)
    {
        List<Automovil> l2 = new List<Automovil>();
        int i = 0;
        while(i < l1.Count)
        {
            if(año == l1[i].AñoFabricación)
                l2.Add(l1[i]);
            i++;
        }
        return l2;
    }
    private static List<Automovil> AutomovilPorAñoDeFabricacionYColor(List<Automovil> l1, int año, string color)
    {
        List<Automovil> l2 = new List<Automovil>();
        int i = 0;
        while(i < l1.Count)
        {
            if(año == l1[i].AñoFabricación && color == l1[i].Color)
                l2.Add(l1[i]);
            i++;
        }
        return l2;
    }
    private static void ImprimeAutomoviles(List<Automovil> l1)
    {
        foreach(var i in l1)
        {
            Console.WriteLine(i);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); /*Os pasé un main... Prueba tu código*/
    }
}
class Automovil
{
    public string Marca{get;set;}
    public string Modelo{get;set;}
    public float Cilindrada{get;set;}
    public int AñoFabricación{get;set;}
    public string Color{get;set;}

    public Automovil(string marca, string modelo, float cilindrada, int añoFabricación, string color)
    {
        Marca = marca;
        Modelo = modelo;
        Cilindrada = cilindrada;
        AñoFabricación = añoFabricación;
        Color = color;
    }
    public override string ToString() => $"Marca: {Marca}\nModelo: {Modelo}\nCilindrada: {Cilindrada}\nAño de fabricación: {AñoFabricación}\nColor: {Color}";
}
