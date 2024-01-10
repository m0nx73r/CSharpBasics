using System.Numerics;

namespace Calculator
{
    internal class Program
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

        static dynamic Add<t1, t2>(t1 a, t2 b)
        {

            int n1, n2;
            double d1, d2;
            if (int.TryParse(a.ToString(), out n1) && int.TryParse(b.ToString(), out n2))
            {
                return n1 + n2;
            }
            if (double.TryParse(a.ToString(), out d1) && double.TryParse(b.ToString(), out d2))
            {
                return d1 + d2;
            }
            else
            {
                return "Please enter numeric value!";
            }

        }


        static dynamic Subtract<t1, t2>(t1 a, t2 b)
        {
            int n1, n2;
            double d1, d2;
            if (int.TryParse(a.ToString(), out n1) && int.TryParse(b.ToString(), out n2))
            {
                return n1 - n2;
            }
            if (double.TryParse(a.ToString(), out d1) && double.TryParse(b.ToString(), out d2))
            {
                return d1 - d2;
            }
            else
            {
                return "Please enter numeric value!";
            }
        }

        static dynamic Multiply<t1, t2>(t1 a, t2 b)
        {
            int n1, n2;
            double d1, d2;
            if (int.TryParse(a.ToString(), out n1) && int.TryParse(b.ToString(), out n2))
            {
                return n1 * n2;
            }
            if (double.TryParse(a.ToString(), out d1) && double.TryParse(b.ToString(), out d2))
            {
                return d1 * d2;
            }
            else
            {
                return "Please enter numeric value!";
            }
        }


        static dynamic Divide<t1, t2>(t1 a, t2 b)
        {
            int n1, n2;
            double d1, d2;
            if (int.TryParse(a.ToString(), out n1) && int.TryParse(b.ToString(), out n2))
            {
                if (n2 != 0)
                {
                    return n1 / n2;
                }
                else
                {
                    return "Second number shouldn't be zero.";
                }
            }
            if (double.TryParse(a.ToString(), out d1) && double.TryParse(b.ToString(), out d2))
            {
                if (d2 != 0)
                {
                    return d1 / d2;
                }
                else
                {
                    return "Second number shouldn't be zero.";
                }
            }
            else
            {
                return "Please enter numeric value!";
            }
        }
    }
}
