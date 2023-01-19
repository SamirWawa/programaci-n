struct Naipe
{
    private readonly int valor;
    public Naipe(in int valor, in Palo palo)
    {
        this.valor=valor;
        this.palo=palo;
    }
    public string ACadena()
    {
        return $"El naipe {valor} {palo}";
    }
    Palo palo;
    public enum Palo{Ceros, Copas, Bastos, Espada}
}
internal class Program
{
    private static void Main(string[] args)
    {
        Naipe[,] baraja=new Naipe[4,12];
        for(int i=0;i<baraja.GetLength(0); i++)
        {
            for(int j=0;j<baraja.GetLength(1); j++)
            {
                baraja[i,j]=new Naipe(j+1,(Naipe.Palo)i);
            }
        }
        foreach(Naipe n in baraja)
            Console.WriteLine(n.ACadena());
        Naipe o= new 
    }
}