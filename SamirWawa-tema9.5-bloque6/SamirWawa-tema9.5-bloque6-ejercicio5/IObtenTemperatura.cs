public interface ICumplePredicado<T>
{
    bool Predicado(T o1, T o2);
}
public interface IObtenTemperatura
{
    float Temperatura(TemperaturasXProvincia txp);
}
class ObtenMaxima : IObtenTemperatura
{
    public float Temperatura(TemperaturasXProvincia tmp) => tmp.TemperaturaMaxima;
}
class ObtenMinima : IObtenTemperatura
{
    public float Temperatura(TemperaturasXProvincia tmp) => tmp.TemperaturaMinima;
}
class MenorQue : ICumplePredicado<float>
{
    public bool Predicado(float o1, float o2)
    {
        return o1 < o2;
    }
}
class MayorQue : ICumplePredicado<float>
{
    public bool Predicado(float o1, float o2)
    {
        return o1 > o2;
    }
}