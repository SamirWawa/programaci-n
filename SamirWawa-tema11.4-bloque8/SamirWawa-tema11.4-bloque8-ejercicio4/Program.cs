internal class Program
{
    private static void Main(string[] args)
    {
        List<double> reales = new List<double>
        {
            0.5, 1.6, 2.8, 3.9, 4.1, 5.2, 6.3, 7.4, 8.1, 9.2
        };
        reales.ForEach(n => Console.Write(n + " "));
        reales.Select(n => n - Math.Floor(n)).Where(n => n < 0.5).Aggregate(0, (c, n) => c++);
        reales.Select(n => Math.Truncate(n)).Where(n => n / 10 % 3 == 0).Aggregate(0, (c, n) => c + (int)n);
        reales.Select(n => new { d = n - Math.Floor(n), r = n }).Where(r => r.d > 0.5).Aggregate(0.0, (c, r) =>
        {
            if (r.r > c)
                c = r.r;
            return r.r;
        });
    }
}