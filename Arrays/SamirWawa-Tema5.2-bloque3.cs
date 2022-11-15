internal class Program
{
    public static void rellenarArray(int[] array)
    {
        Random r = new Random();
        for(int i =0; i<array.Length;i++)
            array[i] = r.Next(0,101);

    }
    public static void VisualizarElementoMayor(int[]array)
    {
        int numeroMayor=default;
        for(int i =0; i<array.Length;i++)
        {
            if(array[i]>numeroMayor)
            {
                numeroMayor=array[i];
            }
        }
        Console.WriteLine("El elemento mayor es "+numeroMayor);
    }
    private static void Main(string[] args)
    {
        /*Ejercicio 1
        Realiza un programa que asigne datos aleatoriamente a un array de n elementos, y a
        continuación muestre el contenido de dicho array utilizando la instrucción foreach.
        int[] ejemplo = new int[10];
        Random r = new Random();

        foreach(int c in ejemplo)
        {
            Console.Write(c+ " ");
        }

        Ejercicio 2
        Rellena un array de 10 números de tipo double, de forma aleatoria, y visualíza los que estén
        en una posición que sea múltiplo de cuatro.
        Para generar un número real entre 0 y 100 puedes hacer:
        double[] ejemplo = new double[10];
        Random semilla = new Random();

        foreach(double c in ejemplo)
        {
            double numeroReal = semilla.NextDouble() * 100d;
            if(ejemplo.Length%4==0)
            {
                Console.Write(numeroReal+" ");
            }
        }

        Ejercicio 6
        Crea un array de 10 elementos, visualiza el elemento mayor de la serie y la posición que
        ocupa. Si hay varios iguales, sólo el primero.
        int[] ejemplo = new int[10];
        rellenarArray(ejemplo);
        VisualizarElementoMayor(ejemplo);

        Ejercicio 8
        Implementa un programa en C#, que dado un número entero sin signo introducido por
        teclado, me diga si es capicúa. Un ejemplo de ejecución sería...
        Número: 1234321
        Es capicúa.
        Nota: Puedes usar el siguiente código para leer un número en forma de array de caracteres.
        char[] numero = Console.ReadLine().ToCharArray();
        bool capicua=true;

        Console.WriteLine("Dime un número");
        char[] numero = Console.ReadLine().ToCharArray();
        char[] aux = new char[numero.Length];
        for(int i =0; i<numero.Length;i++)
        {
            aux[i]=numero[i];
        }
        Array.Reverse(aux,0,numero.Length);
        for(int j=0;j<numero.Length;j++)
        {
            if(numero[j]!=aux[j])
            {
                j=numero.Length;
                capicua=false;
            }
        }
        if(capicua)
        {
            Console.WriteLine("Es capicua");
        }
        else
        {
            Console.WriteLine("No es capicua");
        }
        
        Ejercicio 9
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
    MAIN
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

        EJERCICIO 10
        Introduce por teclado una secuencia de calificaciones de los alumnos de un instituto
        (números enteros entre cero y diez).
        La secuencia termina con la introducción de un número menor que cero o mayor que
        diez.
        Se supone que como máximo podemos tener 25 alumnos.
        Se trata de obtener la frecuencia de las notas (número de veces que cada nota
        aparece).
        💡 Pista: Puedes usar un array para guardar las frecuencias, relacionando la posición del
        array con la nota del alumno. Incrementando el contenido de la posición i , cada vez que
        salga una nota n .
        Ejemplo: Imagina que tengo 10 notas notas = [2][4][4][5][5][5][6][7][7][9]
        En un array de tamaño 11 llamado frecuenciaNotas = [0][0][0][0][0][0][0][0][0][0][0]
        guardaremos la cuenta de cada una de ellas. Fíjate, que los índices en ese array van del 0 al
        10 que son los posibles valores válidos de notas. Por tanto, en la posición de índice 5
        guardaremos la cuenta de las veces que ha aparecido la nota 5 en notas que es 3.
        Al final del proceso de notas el array frecuenciaNotas quedará ...
        0 1 2 3 4 5 6 7 8 9 10
        [ 0 ][ 0 ][ 1 ][ 0 ][ 2 ][ 3 ][ 1 ][ 2 ][ 0 ][ 1 ][ 0 ]*/

        char[] calificaciones=new char[25];
        int[] frecuencia = new int[11];
        string aux ="";
        int nota=default;

        do
        {
            Console.WriteLine("Introduzca notas entre 0 y 10");
            nota = int.Parse(Console.ReadLine());
            aux+=nota.ToString();
        }while(nota>0 || nota<10);

        for(int j=0;j<aux.Length;j++)
        {
            calificaciones[j]=aux[j];
        }

        for(int i=0;i<calificaciones.Length;i++)
        {
            if(calificaciones[i]==0)
                frecuencia[0]+=1;

            if(calificaciones[i]==1)
                frecuencia[1]++;
            
            if(calificaciones[i]==2)
                frecuencia[2]++;

            if(calificaciones[i]==3)
                frecuencia[3]++;

            if(calificaciones[i]==4)
                frecuencia[4]++;

            if(calificaciones[i]==5)
                frecuencia[5]++;
            
            if(calificaciones[i]==6)
                frecuencia[6]++;
            
            if(calificaciones[i]==7)
                frecuencia[7]++;
            
            if(calificaciones[i]==8)
                frecuencia[8]++;

            if(calificaciones[i]==9)
                frecuencia[9]++;
            
            if(calificaciones[i]==10)
                frecuencia[10]++;
        }
        Console.WriteLine(frecuencia);


    }
}
