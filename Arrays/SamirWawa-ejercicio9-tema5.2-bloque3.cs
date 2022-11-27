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

        Console.Write("\nRepetir contraseña:");
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

          /*Todo este código que viene a continuación no es necesario*/
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
          /**********************************************************/
          /* Como has trabajado con dos string... ¿Cómo comparas dos string desde el tema 2?
           if(rep == contraseña)
            Console.WriteLine("Son iguales");
        else
            Console.WriteLine("Son diferentes");
           
           Adapta este código a tu solución. Piensa que lo de antes te ha llevado un buen rato pensarlo y hacer un if-else es cuestión de segundos. Es importante de cara a los exámenes*/
        return hayContraseña;
    }
    public static void Entrar(char[]contraseña, char[]aux)
    {
        string rep="";
        bool correcta=true;
        ConsoleKeyInfo teclaFisica;
        Console.WriteLine("Entrar: \n");
        Console.Write("Introduce constraseña:");
        do /*Este código lo has hecho tres veces. ¿Y si lo modulaziras? ¡Atrévete!*/
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
        for(int i=0;i<contraseña.Length;i++) /*Puedes compararlo directamente con rep, no?*/
        {
            if(contraseña[i]!=aux[i])
            {
                correcta=false;
            }
        }
        if(correcta) /*Retorna al programa principal un booleano y que sea el main quien escriba o no. Si esto lo haces así este módulo será más reutilizable*/
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
