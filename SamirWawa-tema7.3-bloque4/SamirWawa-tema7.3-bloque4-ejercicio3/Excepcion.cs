class ParametroNoValidoException:Exception
{
    private string mensaje;
    public ParametroNoValidoException(string mensaje):base(mensaje)
    {

    }
    public ParametroNoValidoException():base()
    {
        
    }
    
}