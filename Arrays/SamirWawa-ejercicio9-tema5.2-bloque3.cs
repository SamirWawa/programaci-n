internal partial class Program
{
     public static bool recogerContraseña(char[]array, bool hayContraseña)
    {
        string contraseña="";
        string rep="";
        ConsoleKeyInfo teclaFisica;
        hayContraseña=true;
        Console.WriteLine("Registrarse: \n");
        Console.Write("Constraseña:");
        do
        {
            teclaFisica=Console.ReadKey(true);
            if(teclaFisica.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                char caracter=teclaFisica.KeyChar;
                contraseña+=caracter;
            }
        }while(teclaFisica.Key != ConsoleKey.Enter);

        Console.Write("\n Repetir contraseña");
        do
        {
            teclaFisica=Console.ReadKey(true);
            if(teclaFisica.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                char caracter=teclaFisica.KeyChar;
                rep+=caracter;
            }
        }while(teclaFisica.Key != ConsoleKey.Enter);

        for(int i=0;i<contraseña.Length;i++)
        {
            if(contraseña[i]==rep[i])
            {
                for(int j=0;j<contraseña.Length;j++)
                {
                        array[i]=contraseña[i];
                }
            }
            else
            {
                Console.WriteLine("La contraseña no coincide");
                hayContraseña=false;
            }
        }
        return hayContraseña;
    }
    public static void Entrar(char[]contraseña, char[]aux)
    {
        string rep="";
        bool correcta=true;
        ConsoleKeyInfo teclaFisica;
        Console.WriteLine("Entrar: \n");
        Console.Write("Introduce constraseña:");
        do
        {
            teclaFisica=Console.ReadKey(true);
            if(teclaFisica.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                char caracter=teclaFisica.KeyChar;
                rep+=caracter;
            }
        }while(teclaFisica.Key != ConsoleKey.Enter);

        for(int j=0;j<rep.Length;j++)
        {
            aux[j]=rep[j];
        }
        for(int i=0;i<contraseña.Length;i++)
        {
            if(contraseña[i]!=aux[i])
            {
                correcta=false;
            }
        }
        if(correcta)
        {
            Console.WriteLine("La contraseña es correcta");
        }
        else
        {
            Console.WriteLine("La contraseña es incorrecta");
        }
    }
    private static void Main(string[] args)
    {
        //Ejercicio 9
        
        int opcion= default;
        char[] contraseña=new char[20];
        bool hayContraseña=false;
        bool acabar=false;
        char[] aux=new char[20];

      
        do
        {
              Console.WriteLine("Seleccione una opción");
        Console.WriteLine("1. Registrarse en el sistema.");
        Console.WriteLine("2. Entrar al sistema.");
        Console.WriteLine("3. Salir del programa.");
        opcion=int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                {
                    recogerContraseña(contraseña, hayContraseña);
                }
                break;
                case 2:
                {
                    if(hayContraseña)
                    {
                        Entrar(contraseña, aux);
                        acabar=true;
                    }
                    else
                    {
                        Console.WriteLine("Debes Registrarte antes de iniciar sesión");
                    }
                }
                break;
                case 3:
                    acabar=true;
                break;
            }
        }while(acabar==false);
    }
}