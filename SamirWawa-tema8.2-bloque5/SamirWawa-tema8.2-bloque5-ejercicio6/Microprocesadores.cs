class Microprocesador
{
    private string modelo;
    private int nucleos;
    private double frecuencia;

    public Microprocesador(string modelo, int nucleos, double frecuencia)
    {
        this.modelo = modelo;
        this.nucleos = nucleos;
        this.frecuencia = frecuencia;
    }
    public override string ToString()
    {
        return $"Modelo: {modelo}\nNúcleos: {nucleos}\nFrecuencia: {frecuencia}";
    }
    public string ACSV()
    {
        return $"{modelo};{nucleos};{frecuencia}\n";
    }
    public static string AMicroprocesador(string cadena)
    {
        string[] datos = cadena.Split(';');

        return $"Modelo: {datos[0]}\nNúcleos: {datos[1]}\nFrecuencia: {datos[2]}";
    }
}