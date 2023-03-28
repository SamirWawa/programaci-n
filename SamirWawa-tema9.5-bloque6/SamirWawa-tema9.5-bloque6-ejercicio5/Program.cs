
internal class Program
{
    public static void MuestraTemperaturas(TemperaturasXProvincia[] txp, float mediaMaximas, IObtenTemperatura max, ICumplePredicado<float> may)
    {
        for (int i = 1; i < txp.Length; i++)
        {
            may.Predicado(mediaMaximas, txp[i].TemperaturaMaxima);
        }
    }
    public static TemperaturasXProvincia[] RecogeTemperaturas()
    {
        TemperaturasXProvincia[] txp = new TemperaturasXProvincia[5];

        for (int i = 1; i < txp.Length; i++)
        {
            Console.WriteLine("Provincia");
            string provincia = Console.ReadLine();

            Console.WriteLine("Temperatura minima: ");
            float tmpmin = float.Parse(Console.ReadLine());

            Console.WriteLine("Temperatura maxima: ");
            float tmpmax = float.Parse(Console.ReadLine());

            txp[i] = new TemperaturasXProvincia(provincia, tmpmax, tmpmin);
        }

        return txp;
    }
    public static float CalcularMedia(TemperaturasXProvincia[] txp, IObtenTemperatura ot)
    {
        float media = 0.0f;
        for (int i = 1; i < txp.Length; i++)
        {
            media += ot.Temperatura(txp[i]);
        }
        return media / txp.Length;
    }
    private static void Main(string[] args)
    {
        TemperaturasXProvincia[] txp = RecogeTemperaturas();

        float mediaMaximas = CalcularMedia(txp, new ObtenMaxima());
        float mediaMinimas = CalcularMedia(txp, new ObtenMinima());

        MuestraTemperaturas(txp, mediaMaximas, new ObtenMaxima(), new MenorQue());

    }
}