internal class Program
{
    private static void Main(string[] args)
    {
        int[][] matriz=new int[][]
        {
        };
        int filas=default;
        Console.WriteLine("Cuantas filas");
        filas=int.Parse(Console.ReadLine());
        for(int i=0;i<filas;i++)
        {
            Console.WriteLine("Cuantos valores vas a introducir?");
            int valores=int.Parse(Console.ReadLine());
            for(int j=0;j<valores;j++)
            {
                Console.WriteLine("Dime valores");
                matriz[i][j]=int.Parse(Console.ReadLine());
            }
        }

        for(int i=0;i<matriz.Length;i++)
        {
            for(int j=0;j<matriz[i].Length;i++)
            {
                Console.Write(matriz[i][j]+" ");
            }
            Console.WriteLine("");
        }
        
    }
}