using System.Text.RegularExpressions;
using Spectre.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        FileStream f = new FileStream("datos.csv", FileMode.Open, FileAccess.Read);
        StreamReader b = new StreamReader(f, System.Text.Encoding.UTF8);
        var tabla = new Table();
        var timp = new List<(string numero, double valor)> { };
        var vViento = new List<(string numero, double valor)> { };
        bool c = true;
        string patron = @"(\d{4})(\d{2})(\d{2})(T)(\d{2})(\d{2})";

        while(!b.EndOfStream)
        {
            string[] s = b.ReadLine().Split(',');
                if (c)
                {
                    for (int i = 0; i < s.Length; i++)
                        tabla.AddColumn($"[green]{s[i]}[/]");
                    c= false;
                }
                else
                {
                    for (int i = 0; i < s.Length;i= i+5)
                    {
                            Match coincidencia = Regex.Match(s[i+6], patron);
                            int año = int.Parse(coincidencia.Groups[1].Value);
                            int mes = int.Parse(coincidencia.Groups[2].Value);
                            int dia = int.Parse(coincidencia.Groups[3].Value);
                            int hora = int.Parse(coincidencia.Groups[5].Value);
                            int min = int.Parse(coincidencia.Groups[6].Value);
                            DateTime d = new DateTime(año, mes, dia, 0, hora, min);
                            tabla.AddRow(d.ToString(), s[i+7], s[i+8], s[i+9], s[i+10]);
                    }
                    timp.Add((s[0], Convert.ToDouble(s[1].Replace('.', ','))));
                    vViento.Add((s[0], Convert.ToDouble(s[3].Replace('.', ','))));
                }
        }
        b.Close();
        AnsiConsole.Write(tabla);
        AnsiConsole.Write(new BarChart()
           .Width(60)
           .Label($"[green bold underline]Temperatura[/]")
           .CenterLabel()
           .AddItems(timp, (item) => new BarChartItem(
        item.numero, item.valor, Color.Pink1)));
        AnsiConsole.Write(new BarChart()
           .Width(60)
           .Label($"[green bold underline]Velocidad Viento[/]")
           .CenterLabel()
           .AddItems(vViento, (item) => new BarChartItem(
        item.numero, item.valor, Color.Purple)));
        
        
    }
}