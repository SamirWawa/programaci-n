class NumeroCuentaIncorrectoException:Exception
{
    public NumeroCuentaIncorrectoException(string mensaje):base(mensaje)
    {
    }
}

    class SaldoInsuficienteException:Exception
    {
        public SaldoInsuficienteException(string mensaje):base(mensaje)
        {
            
        }
    }