class CuentaCorriente : Cuenta
{
    private int maximoTransaccionesGratuitasPorMes;
    private double recargoXTransaccionAdicional_Euros;
    private int numeroTransaccionesMesActual{get;set;}
    public CuentaCorriente(string numero, string titular, int Transacciones, double recargoXTransaccionAdicional_Euros) : base(numero, titular)
    {
        /*En el constructor debes incializar tus atributos*/
    }
    public void reiniciaTransacciones()
    {
        numeroTransaccionesMesActual = 0;
    }
    public override void Ingreso(double cantidad)
    {
        Saldo = Saldo + cantidad; /*Puedes llamar a ingreso de base que hace esto*/
        numeroTransaccionesMesActual++;
    }

    public override double Reintegro(double cantidad)
    {
        if (Saldo - cantidad > 0) /*Ídem*/
            Saldo = Saldo - cantidad;
        else
        {
            cantidad = Saldo;
            Saldo = 0;
        }
        numeroTransaccionesMesActual++;
        return cantidad;
    }
    public void AplicaRecargosMes()
    {
       /*Sólo hay recargo si nos pasamos del número de transacciones permitidas, hay que comprobarlo antes*/
        Saldo -= (numeroTransaccionesMesActual-maximoTransaccionesGratuitasPorMes)*recargoXTransaccionAdicional_Euros;
    }
    public override string ToString()
    {
        return $"....en Cuenta Corriente{base.ToString()}\nNúmero de Transacciones Realixadas: {numeroTransaccionesMesActual}\nNúmero de Transacciones gratuitas: {maximoTransaccionesGratuitasPorMes}\nRecarga por Transacción: {recargoXTransaccionAdicional_Euros}€\n....";
    }
}
