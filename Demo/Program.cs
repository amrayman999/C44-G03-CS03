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

            //Console.WriteLine("Please enter your name: ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Please enter your age: ");
            //int.TryParse(Console.ReadLine() , out int age);
            //Console.WriteLine("Please enter your salary: ");
            //decimal.TryParse(Console.ReadLine() , out decimal salary);

            //Console.Clear();
            //Console.WriteLine("======== Employee Data ======== ");
            //Console.WriteLine("Name is: " + name);
            //Console.WriteLine("Age is: " + age);
            //Console.WriteLine("Salary is: " + salary);
            #endregion

            #region Part 06 Operators

            #region Unary Operators [ ++ , -- ]
            //int X = 10;
            ////1. ++
            //// 1.1 PreFix [Increment and Then Print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11

            //// 1.2 PostFix [Print and Then Increment]
            //Console.WriteLine(X++); // 10
            //Console.WriteLine(X); // 11

            ////2. --
            //// 2.1 PreFix [Decrement and Then Print]
            //console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            //// 2.2 PostFix [Print and Then Decrement]
            //Console.WriteLine(X--); // 10
            //Console.WriteLine(X); // 9
            #endregion
            #region Binary | Arithmetic Operators [ + , - , * , / , % ]
            //int sumResult, subResult, mulResult, divResult, modResult;
            //int number01 = 6, number02 = 2;
            //sumResult = number01 + number02; // 8
            //subResult = number01 - number02; // 4
            //mulResult = number01 * number02; // 12
            //divResult = number01 / number02; // 3
            //modResult = number01 % number02; // 0
            #endregion
            #region Assignment Operators [ = , += , -= , *= , /= , %= ]
            //int X;
            //X = 4;
            //X += 2; // X = X + 2;
            //X -= 2; // X = X - 2;
            //X *= 2; // X = X * 2;
            //X /= 2; // X = X / 2;
            //X %= 2; // X = X % 2;

            #endregion
            #region Relational | Comparison Operators [ == , != , > , < , >= , <= ]
            //int X = 10, Y = 10;

            //Console.WriteLine(X == Y); // True
            //Console.WriteLine(X != Y); // False
            //Console.WriteLine(X > Y); // False
            //Console.WriteLine(X < Y); // False
            //Console.WriteLine(X >= Y); // True
            //Console.WriteLine(X <= Y); // True

            #endregion
            #region Logical Operators [ && , || , ! ]
            ///// Short-Circuit
            //Console.WriteLine(!true); // False
            //Console.WriteLine(false && true); // False
            //Console.WriteLine(false || true); // True

            //Console.WriteLine(4 < 5 && 7 < 9); // True
            //Console.WriteLine(4 < 5 && 7 > 9); // False
            //Console.WriteLine(4 > 5 && 7 < 9); // False
            #endregion
            #region Bitwise Operators [ & , | , ^ , ~ , << , >> ]
            //// Long Circuit
            //Console.WriteLine(false & true); // False
            //Console.WriteLine(false | true); // True
            //Console.WriteLine(false ^ true); // True

            //int X = 5, Y = 3;  // X = 0101 , Y = 0011
            //Console.WriteLine(X & Y); // 1  (0101 & 0011 = 0001)
            //Console.WriteLine(X | Y); // 7  (0101 | 0011 = 0111)
            //Console.WriteLine(X ^ Y); // 6  (0101 ^ 0011 = 0110)
            //Console.WriteLine(~X); // -6 (complement of 0101 is 1010)
            //Console.WriteLine(X << 1); // 10 (1010)
            //Console.WriteLine(X >> 1); // 2  (0010)
            #endregion
            #region Ternary Operator [Conditional Operator] [ ? : ]
            // int X = 10, Y = 5;
            //if(X > Y)
            //    Console.WriteLine("X > Y");
            //else
            //    Console.WriteLine("X < Y");

            //string Message = X > Y ? "X > Y" : "X < Y";
            //Console.WriteLine(Message);
            #endregion

            #endregion

        }
    }
}
