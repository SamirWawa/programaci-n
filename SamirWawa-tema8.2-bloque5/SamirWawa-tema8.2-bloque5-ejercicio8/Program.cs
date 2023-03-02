using System.Text.RegularExpressions;
internal class Program
{
    private static void BuscarEnCadena(string cadena, string palabra)
    {
        if(Regex.IsMatch(cadena, palabra))/*Cuidadito con esto: subcadenas, patrones...*/
            Console.WriteLine("Existe la palabra en el fichero");
    }

    private static void BuscarEnFichero(string ruta, string palabra)
    {
        FileStream f = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(f, System.Text.Encoding.UTF8);
        string cadena = default;

        while(br.PeekChar() >= 0)
            cadena += br.ReadChar();
        BuscarEnCadena(cadena, palabra);
        br.Close();
    }

    private static void Main(string[] args)
    {
        string ruta = default;
        string palabra = default;

        Console.WriteLine("Define ruta");
        ruta = Console.ReadLine();
        Console.WriteLine("palabra a buscar");
        palabra = Console.ReadLine();

        BuscarEnFichero(ruta, palabra);
    }
}
