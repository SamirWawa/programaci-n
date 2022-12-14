using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Regex patrolComplejo = new Regex(@"[+-]?((\d+)|(\d*[.,]\d+))?|((\d+)|(\d*[.,]\d+))?[ij]([eE][+-]?((\d+)|(\d*[.,]\d+))?|((\d+)|(\d*[.,]\d+))?[ij])?");
        string complejo=default;
        Console.WriteLine("Introduzca un número complejo");
        complejo = Console.ReadLine();
        Match coincidencia = patrolComplejo.Match(complejo);
        if(coincidencia.Success)
            Console.WriteLine("Si es complejo");
        else
            Console.WriteLine("No es complejo");
    }
}