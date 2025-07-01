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
            //long X = 781_423_521_564;
            //Console.WriteLine($"{X:c}");
            //var cultureInfo = new CultureInfo("ar-SA");
            //Console.WriteLine(X.ToString("c", cultureInfo));
            #endregion

            #region Part 02 Implicit & Explicit - Casting
            //int x = 1000; // 4 bytes
            //long y = x; // 8 bytes - implicit casting
            //console.writeline(y);
            //long z = 514587845554544;
            //int w = (int)z; // explicit casting - unsafe casting
            //console.writeline(w);
            // overflow - data loss
            //unchecked
            //{
            //    long X = 25154564548484;
            //    int Y = (int)X;
            //    Console.WriteLine(Y);
            //}
            long X = 5454785784545;
            if (X > int.MaxValue || X < int.MinValue)
                Console.WriteLine("exception will be thrown");
            else
            {
                int Y = (int)X;
                Console.WriteLine(Y);  
            }
            #endregion
        }
    }
}
