namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question (1)
            //Console.WriteLine("Enter Number: ");
            //Console.WriteLine(Console.ReadLine());
            #endregion

            #region Question (2)
            // if we used convert or parse it will throw exception
            // but using tryparse , if it is parsed it return true out parameter contain parsed number
            // , if not it returns false and output paramter contains 0 (the default value of int)
            //string numString = Console.ReadLine();
            //bool isParsed = int.TryParse(numString, out int result);
            //Console.WriteLine(isParsed);
            //Console.WriteLine(result);
            #endregion

            #region Question (3)
            // in this case we use float (f) to represent any floating point number as float, as the result is float)
            //float result = 3.5f + 5 - 2 + 3.555f;
            //Console.WriteLine(result);
            #endregion

            #region Question (4)
            // using substring method in string to get substring 'amr ayman'
            //string myString = "Hello, my name is amr ayman";
            //Console.WriteLine(myString.Substring(18,9));
            #endregion

            #region Question (5)
            // as they are value types , when assigning one to another it takes only a copy of the value
            // so when we change the variable after assignment ,
            // it does not get affected as ebery variable has separate address in memory
            int num1 = 5;
            int num2 = 6;
            num1 = num2;
            num2 = 4;
            Console.WriteLine(num1); // prints 6
            Console.WriteLine(num2); // prints 4
            #endregion



        }
    }
}
