using System.Text;
using System.IO;
internal class Program
{
    enum colores : byte
        {
            None = 0b_0000_0000,
            Negro = 0b_0000_0001,
            Gris = 0b_0000_0010,
            Morado= 0b_0000_0100,
            Azul = 0b_0000_1000,
            Verde = 0b_0001_0000,
            Amarillo = 0b_0010_0000,
            Naranja = 0b_0100_0000,
            Rojo = 0b_1000_0000
        }
    public static Object LeerEnum(Type tipo)
    {
        string entrada=Console.ReadLine();
        do
        {
            if (Enum.IsDefined(tipo, entrada) == false)
            {
                Console.WriteLine("Error");
                string[] enums = Enum.GetNames(tipo);
                foreach (string s in enums)
                    Console.WriteLine(s);
                Console.WriteLine("Escribe uno que este");
                entrada = Console.ReadLine();
            }
        } while (Enum.IsDefined(tipo, entrada) == false);
        return Enum.Parse(tipo, entrada);
    }
    public static string MostrarMenú()
    {
        string menú="1.Añadir colores\n2.Eliminar colores\n3.Mostrar colores\nESC.Salir";
        return menú;
    }
    public static int ElegirOpcion()
    {
        int opcion=int.Parse(Console.ReadLine());
        return opcion;
    }
    public static Object AñadirColores()
    {
        Type tipo= typeof(colores);
        Console.WriteLine("Que color quieres añadir?");
        colores añadir=(colores)LeerEnum(tipo);
        
        return añadir;
    }
    public static Object EliminarColores()
    {
        Type tipo= typeof(colores);
        Console.WriteLine("Color a eliminar");
        colores eliminar=(colores)LeerEnum(tipo);
        return eliminar;
    }
    private static void Main(string[] args)
    {
        int opcion=default;
        
        colores seleccionados=default;
        Console.WriteLine(MostrarMenú());
        opcion=ElegirOpcion();
        do
        {
            switch(opcion)
            {
                case 1:
                seleccionados=(colores)AñadirColores();
                break;
                case 2:
                seleccionados=(colores)EliminarColores();
                break;
                case 3:
                Console.WriteLine(seleccionados);
                break;
            }
        }while(Console.ReadKey().Key!=ConsoleKey.Escape);
    }
}