using System.Text;
internal partial class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string ruta=Console.ReadLine();
            if(Directory.Exists(ruta)==false)
            {
                ruta=Directory.GetCurrentDirectory();
            }
            foreach(var file in Directory.GetDirectories(ruta))
                Console.Write(file);
            foreach(var file in Directory.GetFiles(ruta))
                Console.Write(file);
        }catch(Exception e)
        {
            Console.WriteLine("Error de ruta");
        }
        

        Console.ReadLine();
    }
}