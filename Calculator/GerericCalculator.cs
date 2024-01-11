
namespace Calculator
{
     class GenericCalculator
    {
        public static dynamic Add<t1, t2>(t1 a, t2 b)
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


        public static dynamic Subtract<t1, t2>(t1 a, t2 b)
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

        public static dynamic Multiply<t1, t2>(t1 a, t2 b)
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


        public static dynamic Divide<t1, t2>(t1 a, t2 b)
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
