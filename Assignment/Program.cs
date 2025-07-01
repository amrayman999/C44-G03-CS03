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
            string numString = Console.ReadLine();
            bool isParsed = int.TryParse(numString, out int result);
            Console.WriteLine(isParsed);
            Console.WriteLine(result);
            #endregion


        }
    }
}
