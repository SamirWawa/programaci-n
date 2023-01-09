using System.Threading;
internal class Program
{
        const int ANCHO_CONSOLA = 80;
        const int ALTO_CONSOLA = 24;
        const int FILAS = 6;
        const int COLUMNAS = 7;
        const int SEP_HUECOS_HORIZONTAL = 4;
        const int SEP_HUECOS_VERTICAL = 2;
        const int FILA_TABLERO = ALTO_CONSOLA - FILAS * SEP_HUECOS_VERTICAL - 2;
        const int COLUMNA_TABLERO = ANCHO_CONSOLA / 2 - COLUMNAS * SEP_HUECOS_HORIZONTAL / 2;
		const int FILA_FICHAS = FILA_TABLERO;
		const int COLUMNA_FICHAS = COLUMNA_TABLERO + 2;
        const int NUM_FICHAS_EN_LINEA = 4;
        const int PAUSA_CAIDA_FICHA_MS = 75;
    public enum TipoFicha { SinFicha, FichaJugador1, FichaJugador2 }
    public enum Turno { Jugador1, Jugador2 }

    public static (TipoFicha[,] fichasEnJuego, (string, int)[] jugadores, Turno turno) InicializaJuego()
    {
        InicializaFichasEnJuego();
        InicializaJugadores();
        Turno turno = Turno.Jugador1;
    }
    public static TipoFicha[,] InicializaFichasEnJuego()
    {
        TipoFicha[,] Tablero = new TipoFicha[FILAS, COLUMNAS]
        {
            {TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha},
            {TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha},
            {TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha},
            {TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha},
            {TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha},
            {TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha},
            {TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha, TipoFicha.SinFicha},
        };
        return Tablero;
    }
    public static string[] InicializaJugadores()
    {
        string [] jugadores= new string[2];
        Console.WriteLine("Introduzca nombre del jugador 1");
        jugadores[0]= Console.ReadLine();
        Console.WriteLine("Introduzca nombre del jugador 2");
        jugadores[1]= Console.ReadLine();
        return jugadores;
    }
    public static void DibujaCabeceraYMarcadores((string nombre, int partidasGanadas)[]jugadores, Turno turno)
    {
        Console.SetWindowSize(ANCHO_CONSOLA,ALTO_CONSOLA);
        Console.SetCursorPosition(SEP_HUECOS_HORIZONTAL, SEP_HUECOS_VERTICAL);
        Console.WriteLine("4 en linea Programación 1º DAM");
        Console.Write(jugadores[0], partidasGanadas);
    }
    private static void Main(string[] args)
    {
        InicializaJuego();
        for( int i=0; i<Tablero.GetLength(0); i++ )
        {
            for( int j=0; j< Tablero.GetLength(1); j++ )
            {
                Console.Write(Tablero[i,j]);
            }
        }
    }
}