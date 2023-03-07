class Cuenta
{
    protected NumeroCuenta numero;
    private string titular;
    public double Saldo { get; protected set; }
    public Cuenta(string numero, string titular)
    {
        this.numero = new NumeroCuenta(numero);
        this.titular = titular;
        Saldo = 0;
    }

    public virtual void Ingreso(double cantidad)
    {
        Saldo = Saldo + cantidad;
    }

    public virtual double Reintegro(double cantidad)
    {
        if (Saldo - cantidad > 0)
            Saldo = Saldo - cantidad;
        else
        {
            cantidad = Saldo;
            Saldo = 0;
        }
        return cantidad;
    }

    public override string ToString()
    {
        return $"Numero de cuenta: {numero}\nTitular: {titular}\nSaldo: {Saldo:C}";
    }
}