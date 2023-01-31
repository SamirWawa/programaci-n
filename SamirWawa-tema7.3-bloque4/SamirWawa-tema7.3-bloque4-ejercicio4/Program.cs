using System.Text.RegularExpressions;
class NumeroCuenta
{
    private string entidad;
    private string sucursal;
    private string dcEntSuc;
    private string dcNumero;
    private string cuenta;
    int[] ponderaciones=new int[]{4, 8, 5, 10, 9, 7, 3, 6 };
    public NumeroCuenta(in string numero)
    {
        this.cuenta=numero;
        if(formatoCorrecto(numero)==false)
            throw new NumeroCuentaIncorrectoException("El formato no es correcto");
        else
            if(dcCorrecto(dcEntSuc, entidad+sucursal, ponderaciones)==false)
                throw new NumeroCuentaIncorrectoException("Digitos de control incorrectos por entidad o sucursal");
            if(dcCorrecto(dcNumero, cuenta, ponderaciones)==false)
                throw new NumeroCuentaIncorrectoException("Digitos de control incorrectos por nuero de cuenta");
    }
    private bool formatoCorrecto(in string numero)
    {
        Regex patron=new Regex(@"^(?<entidad>\d{4})\s\(?<sucursal>\d{4})\s\(?<dcEntSuc>\d{1})\(?<dcNumero>\d{1})\s\(?<cuenta>\d{10}$");
        Match coincidencia = patron.Match(numero);
        if(coincidencia.Success)
        {
            entidad=coincidencia.Groups["entidad"].Value;
            sucursal=coincidencia.Groups["sucursal"].Value;
            dcEntSuc=coincidencia.Groups["dcEntSuc"].Value;
            dcNumero=coincidencia.Groups["dcNumero"].Value;
            cuenta=coincidencia.Groups["cuenta"].Value;
        }
        return coincidencia.Success;
    }
    private bool dcCorrecto(in string dc, in string digitos, in int[] ponderaciones)
    {
        int resultado=0;
        for(int i=0; i<ponderaciones.Length;i++)
        {
            resultado+=(int)digitos[i]*ponderaciones[i];
        }
        resultado=11-(resultado%11);
        return dc==resultado.ToString();

    }
    public string ToString()
    {
        return $"número de cuenta bancario:{entidad}{sucursal}{dcEntSuc}{dcNumero}{cuenta}";
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
                try
                {

                }catch(NumeroCuentaIncorrectoException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }while (cuenta.GetSaldo()>0);

    }
}