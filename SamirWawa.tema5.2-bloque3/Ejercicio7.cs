internal class Program
{
    public static void venta(int[,] matriz)
    {
        int entradas=default;
        char sala;
        int sala2=default;
        int sesion=default;
        Console.WriteLine("Cuantas entradas");
        entradas=int.Parse(Console.ReadLine());
        Console.WriteLine("Sala A, B o C");
        sala=char.Parse(Console.ReadLine().ToUpper());
        Console.WriteLine("Cuál sesión? 0, 1 o 2");
        sesion=int.Parse(Console.ReadLine());
        switch(sala)
        {
            case 'A':
            sala2=0;
            break;
            case 'B':
            sala2=1;
            break;
            case 'C':
            sala2=2;
            break;
        }
        if(sala=='A' && entradas<=200)
            matriz[sala2][sesion]-=entradas;
        if(sala=='B' && entradas<=150)
            matriz[sala2][sesion]-=entradas;
        if(sala=='C' && entradas<=125)
            matriz[sala2][sesion]-=entradas;
        else
            Console.WriteLine("Cantidad excedida");
    }
    public static void Estadistica(int[,] matriz)
    {
        for(int i=0;i<matriz.Length;i++)
        {
            for(int j=0;j<matriz[i].Length;j++)
            {
                Console.Write(matriz[i][j]);
            }
            Console.WriteLine("");
        }

    }
    private static void Main(string[] args)
    {
        int opcion=default;
        int[,] matriz=new int[3,3]
        {
            {200,200,200},
            {150,150,150},
            {125,125,125}
        };
        do
        {
            Console.WriteLine("Que operación desea realizar?");
            Console.WriteLine("1.Venta de entradas");
            Console.WriteLine("2.Estadística de aforo");
            opcion=int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                venta(matriz);
                break;
                case 2:
                Estadistica(matriz);
                break;
            }
        }while(Console.ReadKey().Key!=ConsoleKey.Escape);
    }
}