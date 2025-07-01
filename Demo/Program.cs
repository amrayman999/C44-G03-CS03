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
            //long X = 5454785784545;
            //if (X > int.MaxValue || X < int.MinValue)
            //    Console.WriteLine("exception will be thrown");
            //else
            //{
            //    int Y = (int)X;
            //    Console.WriteLine(Y);  
            //}

            #endregion

            #region Part 03 Convert - Casting
            //Console.WriteLine("Please enter your name: ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //console.clear();
            //console.writeline("======== employee data ======== ");
            //console.writeline("name is: " + name);
            //console.writeline("age is: " + age);
            //console.writeline("salary is: " + salary);
            #endregion

            #region Part 04 Parse - Casting
            //Console.WriteLine("Please enter your name: ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Please enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your salary: ");
            //decimal salary = decimal.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("======== Employee Data ======== ");
            //Console.WriteLine("Name is: " + name);
            //Console.WriteLine("Age is: " + age);
            //Console.WriteLine("Salary is: " + salary);
            #endregion

            #region Part 05 TryParse - Casting
            //string numer01 = "100";
            //int X01 = int.Parse(numer01);
            //Console.WriteLine(X01);

            //string numer02 = "ahmed";
            //int X02 = int.Parse(numer02);
            //Console.WriteLine(X02);

            //string numer02 = "Ahmed";
            //bool isParsed = int.TryParse(numer02, out int X02);
            //Console.WriteLine(isParsed);
            //Console.WriteLine(X02);

            Console.WriteLine("Please enter your name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int.TryParse(Console.ReadLine() , out int age);
            Console.WriteLine("Please enter your salary: ");
            decimal.TryParse(Console.ReadLine() , out decimal salary);

            Console.Clear();
            Console.WriteLine("======== Employee Data ======== ");
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Salary is: " + salary);
            #endregion

        }
    }
}
