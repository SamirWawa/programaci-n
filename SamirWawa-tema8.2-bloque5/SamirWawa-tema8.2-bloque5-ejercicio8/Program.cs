using System.Text.RegularExpressions;
internal class Program
{
    private static void BuscarEnCadena(string cadena, Regex palabra)
    {
        Match coincidencia = palabra.Match(cadena);
        int veces = default;

        while(coincidencia.Success)
        {
            veces++;
            Console.WriteLine("Posición aparición: " + coincidencia.Index);
            coincidencia = coincidencia.NextMatch();
        }
        Console.WriteLine("Número de apariciones: " + veces);
    }

    private static void BuscarEnFichero(string ruta, string palabra)
    {
        FileStream f = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(f, System.Text.Encoding.UTF8);
        string cadena = br.ReadString();
        Regex patron = new Regex(palabra);
        BuscarEnCadena(cadena, patron);
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