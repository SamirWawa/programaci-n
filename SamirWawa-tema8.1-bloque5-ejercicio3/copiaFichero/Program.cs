internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ruta de copiado:");
        string rutaInicio = Console.ReadLine();
        Console.WriteLine("Ruta de pegado:");
        string rutaFinal = Console.ReadLine();
        try
        {
            File.Copy(rutaInicio, rutaFinal);
        }catch(Exception e)
        {
            Console.WriteLine("Error");
        }
        Console.ReadLine();
    }
}