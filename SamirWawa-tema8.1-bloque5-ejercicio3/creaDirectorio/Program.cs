internal class Program
{
    private static void Main(string[] args)
    {
        string ruta="";
        ruta=Console.ReadLine();
        try
        {
            if(Directory.Exists(ruta))
                Directory.CreateDirectory(ruta);
        }catch(Exception e)
        {
            Console.WriteLine("Ruta inválida");
        }
        Console.ReadLine();  
    }
}