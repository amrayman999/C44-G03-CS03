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
            string myString = "Hello, my name is amr ayman";
            Console.WriteLine(myString.Substring(18,9));
            #endregion



        }
    }
}
