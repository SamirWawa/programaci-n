internal class Program
{
    public static Microprocesador[] RecogerMicroprocesadores(int numDeMicroprocesadores)
    {
        Microprocesador[] microprocesadores = new Microprocesador[numDeMicroprocesadores];
        string modelo = default;
        int nucleos = default;
        double frecuencia = default;

        for(int i = 0; i < microprocesadores.Length; i++)
        {
            Console.WriteLine("Introduce modelo");
            modelo = Console.ReadLine();

            Console.WriteLine("Introduce nucleos");
            nucleos = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce frecuencia");
            frecuencia = double.Parse(Console.ReadLine());

            microprocesadores[i] = new Microprocesador(modelo, nucleos, frecuencia);
        }
        return microprocesadores;
    }
    public static void Escribir(Microprocesador[] microprocesadores)
    {
        FileStream fs = new FileStream("microprocesadores.csv", FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs, System.Text.Encoding.UTF8);

        for(int i = 0; i < microprocesadores.Length; i++)
        {
            bw.Write(microprocesadores[i].ACSV());
        }
        bw.Close();
    }
    public static void Leer()
    {
        FileStream fs = new FileStream("microprocesadores.csv", FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);
        string cadena = default;

        while(br.PeekChar() >= 0)
            cadena += br.ReadChar();
        br.Close();
    }
    private static void Main(string[] args)
    {
        int opcion = default;
        int numDeMicroprocesadores=default;
        Microprocesador[] microprocesadores = new Microprocesador[0];

        Console.WriteLine("1.escribir\n2.Crear fichero\n3.Leer fichero");
        opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1:
                Console.WriteLine("Cuantos icroprocesadores quieres introducir?");
                numDeMicroprocesadores = int.Parse(Console.ReadLine());
                Array.Resize(ref microprocesadores, numDeMicroprocesadores);
                microprocesadores = RecogerMicroprocesadores(numDeMicroprocesadores);
            break;
            case 2:
                Escribir(microprocesadores);
            break;
            case 3:
                Leer();
            break;
        }
    }
}