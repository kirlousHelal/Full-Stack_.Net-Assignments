using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    static class MathClass
    {
        public static double add(double x, double y) { return x + y; }
        public static double sub(double x, double y) { return x - y; }
        public static double mul(double x, double y) { return x * y; }
        public static double div(double x, double y) { return y != 0 ? x / y : 0; }
    }
}
