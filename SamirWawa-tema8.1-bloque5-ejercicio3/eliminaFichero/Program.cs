internal class Program
{
    private static void Main(string[] args)
    {
        string ruta = Console.ReadLine();
        try
        {
            if(Directory.Exists(ruta))
                File.Delete(ruta);
        }catch(Exception e)
        {
            Console.WriteLine("Error");
        }
        Console.ReadLine();
    }
}