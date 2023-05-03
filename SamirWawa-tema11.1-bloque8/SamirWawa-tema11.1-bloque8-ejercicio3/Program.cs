internal class Program
{
    public delegate void Action<T>(T matriz);
    public static void Muestra<T>(T[][] matriz) 
    {
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for( int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i][j]);
            }
            Console.WriteLine("");
        }
    }
    private static void Main(string[] args)
    {
        string[][] b = 
        {
            new string[]{"Sal", "Agua", "Azucar", "Vino"},
            new string[]{"Cola", "Cafe", "Zumo", "Leche"}
        };
        
        
        Action<string[][]> a = Muestra;
        a(b);
    }
}