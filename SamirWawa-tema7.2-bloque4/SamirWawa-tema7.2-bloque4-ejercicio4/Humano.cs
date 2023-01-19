class Humano
{
    private string nombre;
    private int fuerza;
    private int inteligencia;
    private string sexo;
    private int destreza;
    private int talento;
    private int velocidad;
    private int suerte;

    public Humano(string nombre, int fuerza, int inteligencia, string sexo, int destreza, int talento, int velocidad, int suerte)
    {
        this.nombre=nombre;
        this.fuerza=fuerza;
        this.inteligencia=inteligencia;
        this.sexo=sexo;
        this.destreza=destreza;
        this.talento=talento;
        this.velocidad=velocidad;
        this.suerte=suerte;
    }
    public string ACadena()
    {
        return $"Nombre: {nombre}\nFuerza: {fuerza}\nInteligencia: {inteligencia}\nSexo: {sexo}\nDestreza: {destreza}\nTalento: {talento}\nVelocidad: {velocidad}\nSuerte: {suerte}\n";
    }
    
}
internal class Program
{
    public static Object LeerEnum(Type tipo, string texto, string textoError)
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
    private static void Main(string[] args)
    {
    Arma arma = (Arma)LeerEnum(typeof(Arma),
                                "Introduce el tipo de arma: ",
                                "El tipo de arma es erroneo");

    Armadura armadura = (Armadura)LeerEnum(typeof(Armadura),
                                            "Introduce el tipo de armadura: ",
                                             "El tipo de arma es erroneo");

    Guerrero guerrero = new Guerrero(arma, armadura, "Arturo", 50, 70, "Hombre", 50, 100, 60, 80);

    LibroHechizos libroHechizos = (LibroHechizos)LeerEnum(typeof(LibroHechizos),
                                                            "Introduce el tipo de libro de hechizos: ",
                                                            "El tipo de arma es erroneo");

    Tunica tunica = (Tunica)LeerEnum(typeof(Tunica),
                                        "Introduce el tipo de tunica: ",
                                         "El tipo de arma es erroneo");

     Mago mago = new Mago(libroHechizos, tunica, "Merlin", 30, 65, "Hombre", 100, 40, 50, 100);

    Console.WriteLine(guerrero.ACadena());
    Console.WriteLine(mago.ACadena());
    }
}