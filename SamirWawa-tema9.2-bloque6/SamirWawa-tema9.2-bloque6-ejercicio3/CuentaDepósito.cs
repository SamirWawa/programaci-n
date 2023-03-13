class CuentaDeposito : CuentaAhorro
{
    public double recargo_tpu;
    public bool Vencimiento{get;set;}
    public CuentaDeposito(string numero, string titular, double Interes, double recargo_tpu) : base(titular, numero, Interes)
    {
      /*Inicializar atributos*/
    }
    public override double Reintegro(double cantidad)
    {
        if(Vencimiento) /*Si no se ha vencido*/
            cantidad -= cantidad*Interes_tpu;
        this.Saldo -= cantidad;
        return cantidad;
    }
    public bool FinalizarMes(DateTime fecha)
    {
        return (DateTime.Now>fecha.Date);
    }
    public override string ToString()
    {
        return $"Cuenta de depósito{base.ToString()}";
    }
}
