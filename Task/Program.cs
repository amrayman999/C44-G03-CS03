namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int n1 = 1;
            int n2 = 2;
            int sum, prod, diff;
            Q5(n1, n2, out sum, out prod, out diff);
            Console.WriteLine($"sum: {sum}, prod: {prod}, diff: {diff}");
        }
        static void Q1()
        {
            Console.WriteLine("Enter your input");
            bool isParsed = int.TryParse(Console.ReadLine(), out int age);
            if (isParsed && age > 18)
                Console.WriteLine("Age is Above 18");
            else if (isParsed && age <= 18)
                Console.WriteLine("Age not above 18");
            else
                Console.WriteLine("Invalid input");

        }
        static void Q2()
        {
            //int a = 5;
            //double b = 2.5;
            //double result = a + b * 2;
            // 1. result will be equal 10.0
            // 2. use explicit
            int a = 5;
            double b = 2.5;
            double result = a + (int)b * 2;
            Console.WriteLine(result);

        }
        static void Q3()
        {
        Menu:
            Console.WriteLine("enter your choice [1 add ,2 multiply, 3 exit");
            int? choice = int.Parse(Console.ReadLine());
            Console.Write("first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("second number: ");
            int num2 = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sum is : " + num1 + num2);
                    goto Menu;
                case 2:
                    Console.WriteLine("multiplication is : " + num1 * num2);
                    goto Menu;
                case 3:
                    Console.WriteLine("Exited");
                    break;

            }
        }
        static void Q4()
        {
            Console.Write("enter product name: ");
            string pname = Console.ReadLine();
            Console.Write("enter product price: ");
            double pprice = double.Parse(Console.ReadLine());
            Console.Write("enter product quantity: ");
            int pquantity = int.Parse(Console.ReadLine());
            double total = pprice * pquantity;
            string message = $"Product: {pname}\nPrice: {pprice:c}\nQuantity: {pquantity}\nTotal: {total:c}";
            Console.WriteLine(message);
        }
        static void Q5(int n1, int n2, out int sum, out int prod, out int diff)
        {
            sum = n1 + n2;
            prod = n1 - n2;
            diff = n1 - n2;
        }



    }
}
