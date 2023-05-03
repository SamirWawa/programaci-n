
internal class Program
{
    public delegate void Infinitivo();
    public static void Ser() => Console.WriteLine("be");
    public static void Correr() => Console.WriteLine("run");
    public static void Ver() => Console.WriteLine("see");
    public static void Pensar() => Console.WriteLine("think");
    public static void Comer() => Console.WriteLine("eat");
    private static void Main(string[] args)
    {
        Infinitivo inf = Ser;
        inf += Correr;
        inf += Ver;

        inf();

        inf -= Ser;
        inf -= Ver;
        inf += Pensar;
        inf += Comer;

        inf();
    }
}