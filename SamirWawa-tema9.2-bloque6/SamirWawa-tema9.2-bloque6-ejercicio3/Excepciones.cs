class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string mensaje) : base(mensaje)
    {

    }
}

class NumeroCuentaIncorrectoException : Exception
{
    public NumeroCuentaIncorrectoException(string mensaje) : base(mensaje)
    {

    }
}

class CreditoMaximoExcedidoException : Exception
{
    public CreditoMaximoExcedidoException(double creditoMaximo_Euros, double creditoConcedidoHastaAhora_Euros, double cantidadAReintegrar_Euros)
    {

    }
}