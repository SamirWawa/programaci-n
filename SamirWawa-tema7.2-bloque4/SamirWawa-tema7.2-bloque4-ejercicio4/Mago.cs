enum LibroHechizos
{
    Básico, Intermedio, Avanzado, Maestro, Total
}
enum Tunica
{
    Hierro, Cobre, EscamasDeDragónVenenoso, EscamasDeDragónLlameante, EscamasDeDragónEléctrico, EscamasDeDragónLuminoso, EscamasDeDragónOscuro, EscamasDeDragónPuro
}
class Mago:Humano
{
    private LibroHechizos libroHechizos;
    private Tunica tunica;
    public Mago(LibroHechizos libroHechizos, Tunica tunica, string nombre, int fuerza, int inteligencia, string sexo, int destreza, int talento, int velocidad, int suerte):base(nombre, fuerza, inteligencia, sexo, destreza, talento, velocidad, suerte)
    {
        this.libroHechizos=libroHechizos;
        this.tunica=tunica;
    }
    
    public virtual new string ACadena() /*Usar override*/
    {
        return $"{base.ACadena()}Arma: {libroHechizos}\nArmadura: {tunica}\n";
    }
}
