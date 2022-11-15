internal partial class Program
{
    public static void rellenarArray(int[] array)
    {
        Random r = new Random();
        for(int i =0; i<array.Length;i++)
            array[i] = r.Next(0,101);

    }
    public static void VisualizarElementoMayor(int[]array)
    {
        int numeroMayor=default;
        for(int i =0; i<array.Length;i++)
        {
            if(array[i]>numeroMayor)
            {
                numeroMayor=array[i];
            }
        }
        Console.WriteLine("El elemento mayor es "+numeroMayor);
    private static void Main(string[] args)
    {
        /*Ejercicio 6
        Crea un array de 10 elementos, visualiza el elemento mayor de la serie y la posición que
        ocupa. Si hay varios iguales, sólo el primero.*/
        int[] ejemplo = new int[10];
        rellenarArray(ejemplo);
        VisualizarElementoMayor(ejemplo);
        
       
    }
}