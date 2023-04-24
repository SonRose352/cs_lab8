using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Functions3
    {
        //Делегат
        public delegate double F(double x);

        //Функции делегата
        public static double taskA(double x)
        {
            return x * Math.Sin(x) - 0.5;
        }

        public static double taskBC(double x)
        {
            return Math.Log10(x * x - 3 * x + 2);
        }

        public static double taskD(double x)
        {
            return 0.5 * Math.Tan(2 * (x + Math.PI / 4) / 3) - 1;
        }

        public static double FindRoot(double a, double b, F func)
        {
            double x;
            double e = 0.0001;
            do
            {
                x = (b + a) / 2;
                if (func(x) == 0)
                    return x;
                else
                {
                    if (func(a) * func(x) < 0)
                        b = x;
                    else
                        a = x;
                }
            }
            while (Math.Abs(func(x)) >= e && Math.Abs(b - a) >= e);
            return x;
        }
    }
}
