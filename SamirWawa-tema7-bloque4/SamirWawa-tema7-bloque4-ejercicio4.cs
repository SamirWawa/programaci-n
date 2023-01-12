class Compas
{
    public Circulo DibujaCirculo(float radio)
    {
        return new Circulo(radio);
    }
}
class Circulo
{
    private float radio;
    public Circulo(in float radio)
    {
        this.radio=radio;
    }
    public double Perimetro()
    {
        return 2*Math.PI*radio;
    }
    public double Area()
    {
        return Math.PI*Math.Pow(radio, 2);
    }
}
class Rotulador
{
    Color color;
    
    public Rotulador(Color color)
    {
        this.color=color;
    }
    public void Rotula(double perimetro)
    {
        Console.WriteLine($"Rotulado el perímetro de {perimetro}cm de color {color}");
    }
}
class Pincel
{
    Color color;
    public void SetColor(Color color)
    {
        this.color=color;
    }
    public void Pinta(double area)
    {
        Console.WriteLine($"Pintado el área de {area}cm^2 de color {color}");
    }
}
static class Estuche
{
    public const int NUMERO_ROTULADORES=3;
    public static Rotulador[] GetRotuladores()
    {
        Rotulador[] rotuladores= new Rotulador[NUMERO_ROTULADORES];
        rotuladores[0] = new Rotulador(Color.Verde);
        rotuladores[1] = new Rotulador(Color.Azul);
        rotuladores[2] = new Rotulador(Color.Verde);
        return rotuladores;
    }
}
public enum Color
    {
        Verde, Azul
    }
internal class Program
{
    private static void Main(string[] args)
    {
        Compas compas = new Compas();
        Circulo circulo = compas.DibujaCirculo(3.5f);
        Rotulador rotulador = Estuche.GetRotuladores()
                        [
                            new Random().Next(0, Estuche.NUMERO_ROTULADORES)
                        ];
        rotulador.Rotula(circulo.Perimetro());
        Pincel pincel = new Pincel();
        pincel.SetColor(Color.Verde);
        pincel.Pinta(circulo.Area());
    }
}