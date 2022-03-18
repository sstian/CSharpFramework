using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static double Mul(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            if (0 == b)
            {
                return double.PositiveInfinity;
            }
            return a / b;
        }

        public static int SumFrom1ToX(int x)
        {
            return (1 + x) * x / 2;
        }
    }
}
