class CuentaAhorro:Cuenta
{
    public double Interes_tpu{get; set;}
    public CuentaAhorro(string numero, string titular, double Interes_tpu):base(numero, titular)
    {

    }
    public void SumaInteres()
    {
        Saldo += (Saldo*Interes_tpu/100);
    }
    public override string ToString()
    {
        return $"....en Cuenta Ahorro\n{base.ToString()}\nInterés: {Interes_tpu}%\n....";
    }
}