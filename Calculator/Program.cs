namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string? c;

            Console.WriteLine("Hello, Welcome to the calculator program!");
            Console.Write("Please enter the first number: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("Please enter the operation you want to perform on both the numbers. Enter 'a' for addition, 's' for subtraction, 'm' for multiplication, 'd' for division: ");
            c = Console.ReadLine();
            if (c == "a")
            {
                Console.WriteLine("The result of addition is: {0}", a + b);
            }
            else if (c == "s")
            {
                Console.WriteLine("The result of subtraction is: {0}", a - b);
            }
            else if (c == "m")
            {
                Console.WriteLine("The result of multiplication is: {0}", a * b);
            }
            else if (c == "d")
            {
                Console.WriteLine("The result of division is: {0}", a/b);
            }
            else
            {
                Console.WriteLine("You have provided incorrect input");
            }
        }
    }
}
