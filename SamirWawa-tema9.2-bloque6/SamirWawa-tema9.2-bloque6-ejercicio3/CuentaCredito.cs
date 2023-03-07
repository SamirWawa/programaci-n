class CuentaCredito:Cuenta
{
    private double interes_tpu;
    private double creditoMaximo_Euros;

    public CuentaCredito(string numero, string titular,double interes_tpu, int Transacciones) : base(numero, titular)
    {
    }
    public override double Reintegro(double cantidad)
    {
        if(cantidad>creditoMaximo_Euros)
            throw new CreditoMaximoExcedidoException(creditoMaximo_Euros, Saldo, cantidad);
        if (Saldo - cantidad > 0)
            Saldo = Saldo - cantidad;
        else
        {
            cantidad = Saldo;
            Saldo = 0;
        }
        return cantidad;
    }
    public double CargaInteresesMes()
    {
        double cargo = (Saldo < 0) ? Math.Abs(Saldo) * interes_tpu : 0d;
        Saldo -=cargo;
        return cargo;

    }
    public override string ToString()
    {
        return $"Cuenta Crédito{base.ToString()}\nInterés: {interes_tpu}%\nCredito Máximo: {creditoMaximo_Euros}€\n....";
    }
}