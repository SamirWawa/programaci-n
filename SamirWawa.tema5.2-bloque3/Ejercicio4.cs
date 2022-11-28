internal class Program
{
    public static void BuscarPais(char[][] paises)
    {
        string buscar="";
        int buscado=default;
        buscar=Console.ReadLine();
        buscado=Array.IndexOf(buscar.ToCharArray(),paises);
        for(int i=0;i<paises.Length;i++)
        {
            Console.WriteLine(paises[buscado][i]);
        }
    }

    public static void MostrarPais(char[][] paises)
    {
        for(int i=0;i<paises.Length;i++)
        {
            for(int j=0;j<paises[i].Length;i++)
            {
                Console.WriteLine(paises[i][j]);
            }
        }
    }

    public static void OrdenarPais(char[][] paises)
    {
        Array.Sort(paises);
        Console.WriteLine(paises);
    }

    public static void AñadirPrefijo(char[][] paises)
    {
        
    }
    private static void Main(string[] args)
    {
        /*Ejercicio 4
        Tenemos una tabla dentada de caracteres char[][] paises , que tiene almacenados los nombres
        de 20 países.
        Se pide diseñar un programa que realice, tantas veces como sea requerido por el usuario, las
        siguientes operaciones:

        1. Buscar un país.
        2. Mostrar países.
        3. Ordenar países.
        4. Añadir prefijo a un país.

        Otras consideraciones...
        El prefijo estará formado por 2 caracteres, habrá un espacio en blanco entre el nombre y el
        prefijo. Para añadir el prefijo a la fíla correspondiente del país, puedes redimensionar la fila de
        la dentada usando el método:

        Array.Resize(ref paises[paisEncontrado], paises.Length+3)

        Para ordenar la dentada alfabéticamente, utilizaremos el método de ordenación de la burbuja
        (hay un ejemplo en los apuntes). Para comparar cadenas alfabéticamente debes usar el
        método CompareTo de cadena.
        💡 Pista: para programar este ejercicio podemos pasar de array de char a string o viceversa,
        cuando lo necesitemos. Recordar que para pasar de string a array de char usaremos
        cadena.TocharArray() y de array de char a string con new String(array)*/
        char[][] paises=new char[][]
        {
            "españa".ToCharArray(),
            "portugal".ToCharArray(),
            "francia".ToCharArray(),
            "perú".ToCharArray(),
            "afganistán".ToCharArray(),
            "alemania".ToCharArray(),
            "andorra".ToCharArray(),
            "argentina".ToCharArray(),
            "australia".ToCharArray(),
            "brasil".ToCharArray(),
            "canadá".ToCharArray(),
            "catar".ToCharArray(),
            "chile".ToCharArray(),
            "chad".ToCharArray(),
            "china".ToCharArray(),
            "colombia".ToCharArray(),
            "cuba".ToCharArray(),
            "india".ToCharArray(),
            "congo".ToCharArray(),
            "zimbawe".ToCharArray(),
        };
        int opcion=default;
        string paisEncontrado="";

        do
        {
            Console.WriteLine("Que operación deseas realizar?");
            Console.WriteLine("1. Buscar un país.");
            Console.WriteLine("2. Mostrar países.");
            Console.WriteLine("3. Ordenar países.");
            Console.WriteLine("4. Añadir prefijo a un país.");
            Console.WriteLine("ESC-Salir");
            opcion=int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                Console.WriteLine("Pais a buscar:");
                BuscarPais(paises);
                break;
                case 2:
                MostrarPais(paises);
                break;
                case 3:
                OrdenarPais(paises);
                break;
                case 4:
                AñadirPrefijo(paises);
                break;
            }
        }while(Console.ReadKey().Key!=ConsoleKey.Escape);

    }
}