using System.Text.RegularExpressions;
internal class Program
{
    public static void Validar(Regex patron, string validado)
    {
        bool valida=patron.IsMatch(validado);
        if(valida)
            Console.WriteLine("Fromato correcto");
        else
            Console.WriteLine("Formato incorrecto");
    }
    private static void Main(string[] args)
    {
        /*string fecha;
        Regex patronfecha=new Regex(@"^\d{2}[\s/-]\d{2}[\s/-]\d{4}$");

        Console.WriteLine("Introduzca fecha");
        fecha=Console.ReadLine();
        Validar(patronfecha,fecha);

        string matricula;
        Regex patronmatricula1=new Regex(@"^[A-Z]{2}[\s-]\d{4}[\s-][A-Z]{2}$");
        Regex patronmatricula2=new Regex(@"^\d{4}[\s-][A-Z]{3}$");

        Console.WriteLine("Introduzca matrícula");
        matricula=Console.ReadLine();
        Validar(patronmatricula1, matricula);
        Validar(patronmatricula2, matricula);*/

        string real;
        Regex patronreal1=new Regex(@"^\d+,\d+E\d+$");
        Regex patronreal2=new Regex(@"^-, \d+e-\d+$");
        Regex patronreal3=new Regex(@"^0,\d+E/+\d+$");
        
        Console.WriteLine("Introduzca un real con exponente");
        real=Console.ReadLine();
        Validar(patronreal1,real);
        Validar(patronreal2,real);
        Validar(patronreal3,real);


        
    }
}