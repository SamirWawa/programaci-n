internal class Program
{
    private static void Main(string[] args)
    {
        Persona p1 = new Persona(12, "A");
        Persona p2 = new Persona(12, "B");
        Object P3 = p1.Clone();
        Console.WriteLine(Persona.Menor(p1, p2));
        Console.WriteLine(P3);
        Console.WriteLine(Persona.Menor(p1, P3));
    }
}