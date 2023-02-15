internal class Program
{
    private static void Main(string[] args)
    {
        string ruta = @"C:\datos\datos.txt";
        FileStream f = null;
        BinaryWriter b = null;
        try
        {
            if(Directory.Exists(Path.GetDirectoryName(ruta))==false);
                Directory.CreateDirectory(Path.GetDirectoryName(ruta));

            f = new FileStream(ruta,FileMode.CreateNew, FileAccess.Write);
            b = new BinaryWriter(f, System.Text.Encoding.UTF8);
            b.Write(Console.ReadLine());
            b.Close();
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }finally
        {
            f.Close();
        }
    }
}