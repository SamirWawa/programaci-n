using System.Text;
using System.IO;
internal class Program
{
    enum Abono
    {
        QuinceDias = 70,
        TreintaDias = 60,
        FamiliasNumerosas = 50,
        TerceraEdad = 30,
        Discapacidad = 20,
        Juvenil = 65,
        Infantil = 35,
        Turístico = 90
    }
    public static double Dirige(Abono a)
    {
        int dias = 0;
        if (a == Abono.QuinceDias)
            dias = 15;
        if (a == Abono.TreintaDias)
            dias = 30;
        if (dias == 0)
            do
            {
                Console.WriteLine("Cuantos días");
                dias = int.Parse(Console.ReadLine());
            } while (dias < 7 || dias > 60);
        double precio = Calcula(a, dias);
        return precio;
    }
    static double Calcula(Abono a, int dias)
    {
        double precio = a * dias / 100;
        return precio;
    }
    public static Object LeerEnum(Type tipo, string texto, string textoError)
    {
        Console.WriteLine(texto);
        string entrada=Console.ReadLine();
        do
        {
            if (Enum.IsDefined(tipo, entrada) == false)
            {
                Console.WriteLine(textoError);
                string[] enums = Enum.GetNames(tipo);
                foreach (string s in enums)
                    Console.WriteLine(s);
                Console.WriteLine("Escribe uno que este");
                entrada = Console.ReadLine();
            }
        } while (Enum.IsDefined(tipo, entrada) == false);
        return Enum.Parse(tipo, entrada);
    }
    private static void Main(string[] args)
    {
        double precio = 0;
        string texto = "Escribe el que quieras";
        string textoError = "No existe";
        Type tipo = typeof(Abono);
        Abono a = (Abono)LeerEnum(tipo, texto, textoError);
        precio = Dirige(a);
        Console.WriteLine("Abono " + a + " " + precio + " euros");
    }
    
    
    
}