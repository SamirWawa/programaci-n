internal partial class Program
{
    private static void Main(string[] args)
    {
        /*Ejercicio 8
        Implementa un programa en C#, que dado un número entero sin signo introducido por
        teclado, me diga si es capicúa. Un ejemplo de ejecución sería...
        Número: 1234321
        Es capicúa.
        Nota: Puedes usar el siguiente código para leer un número en forma de array de caracteres.
        char[] numero = Console.ReadLine().ToCharArray();
        bool capicua=true;*/

        Console.WriteLine("Dime un número");
        char[] numero = Console.ReadLine().ToCharArray();
        char[] aux = new char[numero.Length];
        for(int i =0; i<numero.Length;i++)
        {
            aux[i]=numero[i];
        }
        Array.Reverse(aux,0,numero.Length);
        for(int j=0;j<numero.Length;j++) /*Ya que llevas un booleano para controlar si es capicua, mejor salir del bucle con for(... j<numero.length &&capicua...) y no modificar el valor de j.*/
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
    }
}
