internal class Program
{
    public static double Calculalogaritmo(double num)
    {
        if(num<=0)
            throw new ParametroNoValidoException ("Que sea mayor que 0");
        else
            return Math.Log10(num);
    }
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Dime un número");
            double num =double.Parse(Console.ReadLine());
            Console.WriteLine(Calculalogaritmo(num));
        }catch(FormatException e)
        {
            Console.WriteLine("Pero pon un número merengue");
        }
        catch(ParametroNoValidoException cero)
        {
            Console.WriteLine(cero.Message);
        }
    }
}
