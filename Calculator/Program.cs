using System.Numerics;

namespace Calculator
{
    class Program : CalculatorFunctions
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(7, 9));

            Console.WriteLine(Add(10.4, 9.2));
            Console.WriteLine(Add(7.1, 9));
            Console.WriteLine(Add("12", "14"));

            Console.WriteLine(Add(7, ""));
            Console.WriteLine(Add("git", "hub"));

            Console.WriteLine();

            Console.WriteLine(Subtract(7, 9));
            Console.WriteLine(Subtract("abcd", "Sdfds"));
            Console.WriteLine(Subtract(27.2, 9.2));
            Console.WriteLine();


            Console.WriteLine(Multiply(5, 8.7));
            Console.WriteLine(Multiply("abcd", "Sdfds"));

            Console.WriteLine();

            Console.WriteLine(Divide(55.2, 8.7));
            Console.WriteLine(Divide(4, 2));
            Console.WriteLine(Divide("abcded", "Sdfds"));

        }
    }
}
