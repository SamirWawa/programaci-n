enum Arma
{
    EspadaYEscudo, EspadaADosManos, Puños, Maza, HachaYEscudo, HachaADosManos, HachasDobles, Mazo, Ancla 
}
enum Armadura
{
    Cuero, Hierro, MetalSolar, EscamasDeDragónVenenoso, EscamasDeDragónLlameante, EscamasDeDragónEléctrico, EscamasDeDragónLuminoso, EscamasDeDragónOscuro, EscamasDeDragónPuro
}

class Guerrero:Humano
{
   
    private Arma arma;
    private Armadura armadura;
    public Guerrero(Arma arma, Armadura armadura, string nombre, int fuerza, int inteligencia, string sexo, int destreza, int talento, int velocidad, int suerte):base(nombre, fuerza, inteligencia, sexo, destreza, talento, velocidad, suerte)
    {
        this.arma=arma;
        this.armadura=armadura;
    }
    public Object LeerEnum(Type tipo, string texto, string textoError)
    {
        Console.WriteLine(texto);
        string entrada=Console.ReadLine();
        do
        {
            if (Enum.IsDefined(tipo, entrada) == false)
            {
                Console.WriteLine(textoError);
                string[] enums = Enum.GetNames(tipo);
                foreach (string s in enums)
                    Console.WriteLine(s);
                Console.WriteLine("Escribe uno que este");
                entrada = Console.ReadLine();
            }
        } while (Enum.IsDefined(tipo, entrada) == false);
        return Enum.Parse(tipo, entrada);
    }
    public virtual new string ACadena()
    {
        return $"{base.ACadena()}Arma: {arma}\nArmadura: {armadura}\n";
    }
    
}