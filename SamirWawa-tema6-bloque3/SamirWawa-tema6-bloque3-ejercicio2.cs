using System.Text.RegularExpressions;
internal class Program
{
    public static int Control(string numcuenta)
    {
        int[] aux = new int[numcuenta.Length];
        int j=numcuenta.Length;
        int suma=default;
        int multiplo=default;
        int total=default;
        for(int i=0;i<numcuenta.Length;i++)
        {
            aux[j]=numcuenta[i];
            j--;
        }
        for(int i=0;i< aux.Length;i++)
        {
            if(aux[i]%2!=0)
            {
                aux[i]=aux[i]*3;
            }
        }
        for(int i=0;i<aux.Length;i++)
        {
            suma+=aux[i];
        }
        multiplo=suma+(suma/10)%10;
        total=multiplo-suma;
        return total;
    }
    private static void Main(string[] args)
    {
        string numcuenta;
        int supcontrol=default;
        Regex patroncuenta= new Regex(@"^?<entidad>\d{4} ?<sucursal>\d{4} ?<control>\d{2} ?<cuenta>\d{10}");
        Console.WriteLine("Introduzca número de cuenta");
        numcuenta=Console.ReadLine();

        Match coincidencia = patroncuenta.Match(numcuenta);
        if(coincidencia.Success)
        {
            Console.WriteLine("Formato correcto");
            supcontrol=Control(numcuenta);
            int control= int.Parse(coincidencia.Groups["control"].Value);
            if(supcontrol!=control)
            {
                Console.WriteLine("Numero de control incorrecto");
            }
        }
        else
            Console.WriteLine("Formato incorrecto");

        

    }
}