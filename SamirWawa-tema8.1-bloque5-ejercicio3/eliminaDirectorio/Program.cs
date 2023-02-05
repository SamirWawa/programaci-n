internal class Program
{
    private static void Main(string[] args)
    {
        string ruta=Console.ReadLine();
        try
        {
            if(Directory.Exists(ruta))
                Directory.Delete(ruta);
        }catch(Exception e)
        {
            Console.WriteLine("Error de ruta");
        }
        Console.ReadLine();
    }
}