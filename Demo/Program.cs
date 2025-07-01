using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Fractions & Discards
            //float X = 3.5587847458f;
            //double Y = 3.5;
            //decimal Z = 3.5m;
            //Console.WriteLine(X);
            long X = 781_423_521_564;
            Console.WriteLine($"{X:c}");
            var cultureInfo = new CultureInfo("ar-SA");
            Console.WriteLine(X.ToString("c", cultureInfo));
            #endregion
        }
    }
}
