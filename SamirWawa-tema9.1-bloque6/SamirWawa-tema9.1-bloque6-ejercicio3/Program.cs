namespace Estadistica
{
    public class Promedio
    {
        private double[] nums;
        public Promedio(double[] nums)
        {
            this.nums = nums;
        }
        public double Media()
        {
            double media = default;
            for (int i = 0; i < nums.Length; i++)
                media += nums[i];
            return media / nums.Length;
        }
        public double Mayor()
        {
            Array.Sort(nums);
            return nums[nums.Length - 1];
        }
        public double Menor()
        {
            Array.Sort(nums);
            return nums[0];
        }
        public double Rango()
        {
            Array.Sort(nums);
            return nums[nums.Length - 1] - nums[0];
        }
        public double Mediana()
        {
            if (nums.Length % 2 == 0)
            {
                Array.Sort(nums);
                return (nums[(nums.Length - 1) / 2] + nums[(nums.Length - 1) / 2 + 1]) / 2;
            }
            else
                return nums[nums.Length / 2];
        }
        public double Moda()
        {
            double moda = 0;
            double n = 0;
            double o = 0;
            double p = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                p = nums[i];
                for (int j = 0; j < nums.Length; j++)
                    if (j != i && nums[i] == nums[j])
                        n++;
                if (o < n)
                {
                    o = n;
                    moda = nums[i];
                }
                n = 0;
            }
            return moda;
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] d = {3, 7, 5, 7, 4, 3};
            Promedio p = new Promedio(d);
            Console.WriteLine(p.Media);
            Console.WriteLine(p.Mediana);
            Console.WriteLine(p.Moda);
            Console.WriteLine(p.Rango);
        }
    }
}
