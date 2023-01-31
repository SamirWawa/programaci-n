class Cuenta
{
    private string titular;
    private double saldo;
    public Cuenta(in string numero, in string titular)
    {
        NumeroCuenta numerocuenta=new NumeroCuenta(numero);
        this.titular=titular;
        this.saldo=0;
    }
    public void Ingreso(in double cantidad)
    {
        saldo+=cantidad;
    }
    public void Reintegro(in double cantidad)
    {
        if(cantidad>saldo)
            throw new SaldoInsuficienteException("No saques mas de lo que tienes pobre");
    }
    public double GetSaldo()
    {
        return saldo;
    }
    public string Tostring()
    {
        return $"";
    }
}