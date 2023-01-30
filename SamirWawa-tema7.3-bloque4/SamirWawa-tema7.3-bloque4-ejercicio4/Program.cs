using System.Text.RegularExpressions;
class NumeroCuenta
{
    private string entidad;
    private string sucursal;
    private string dcEntSuc;
    private string dcNumero;
    private string cuenta;
    public NumeroCuenta(in string numero)
    {
        this.cuenta=numero;
        if(formatoCorrecto(numero)==false)
            throw new NumeroCuentaIncorrectoException("El formato no es correcto");
        else
            if(dcCorrecto(dcEntSuc, dcEntSuc, 4, 8, 5, 10, 9, 7, 3, 6 )==false)
                throw new NumeroCuentaIncorrectoException("Digitos de control incorrectos");
    }
    private bool formatoCorrecto(in string numero)
    {
        Regex patron=new Regex(@"^(?<entidad>\d{4})\(?<sucursal>\d{4})\(?<dcEntSuc>\d{2})\(?<cuenta>\d{10}$");
        Match coincidencia = patron.Match(numero);
        if(coincidencia.Success)
        {
            entidad=coincidencia.Groups["entidad"].Value;
            sucursal=coincidencia.Groups["sucursal"].Value;
            dcEntSuc=coincidencia.Groups["dcEntSuc"].Value;
            cuenta=coincidencia.Groups["dcNumero"].Value;
        }
        return coincidencia.Success;
    }
    private bool dcCorrecto(in string dc, in string digitos, in int[] ponderaciones)
    {
        
    }
    public string ToString()
    {
        return "";
    }
}
internal partial class Program
{
    private static void Main(string[] args)
    {
        Cuenta cuenta=new Cuenta("2085 0103 92 0300731702", "John Doe");
        cuenta.Ingreso(15400);
        Console.WriteLine(cuenta);
        do
        {
            {
                Console.Write("¿Cuanto quieres sacar?");
                double reintegro = double.Parse(Console.ReadLine());
                cuenta.Reintegro(reintegro);
                {

                }
                Console.WriteLine(e.Message);
            }
        }while (Cuenta.GetSaldo()>0);

    }
}