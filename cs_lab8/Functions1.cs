using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab8
{
    class Functions1
    {
        //Делегат
        public delegate double F(double x);

        //Делегат условия
        public delegate bool option(double y);

        //Методы делегата
        public static double taskB(double x)
        {
            return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1;
        }

        public static double taskC(double x)
        {
            return -1 * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI;
        }

        public static double taskD(double x)
        {
            double y = 0;
            for (int i = 1; i <= 100; i++)
            {
                y += Math.Pow(x / (Math.PI * i) - 1, 2);
            }
            return y;
        }

        public static double taskE(double x)
        {
            if (x < 0)
                return 0.25 * Math.Pow(Math.Sin(x), 2) + 1;
            else
                return 0.5 * Math.Cos(x) - 1;
        }

        //Методы делегата условия
        public static bool opt1(double y)
        {
            if (y < 0) return true;
            else return false;
        }

        public static bool opt2(double y)
        {
            if (y >= -1 && y <= 1) return true;
            else return false;
        }

        //Встроенный делегат
        public delegate TResult Func<in T, out TResult>(T arg);

        //Метод PrintFunc
        public static void PrintFunc(double a, double b, double dx, F del)
        {
            Console.WriteLine("\nЗначения функции {3} на отрезке [{0}, {1}] с шагом {2}", a, b, dx, del.Method.Name);
            for (double x = a; x <= b; x += dx)
            {
                Console.WriteLine("x = {0}\tf(x) = {1}", x, del(x));
            }
        }

        //Метод PrintFunc для встроенного делегата TResult
        public static void PrintResult(double a, double b, double dx, Func<double, double> del)
        {
            Console.WriteLine("\nЗначения функции {3} на отрезке [{0}, {1}] с шагом {2}", a, b, dx, del.Method.Name);
            for (double x = a; x <= b; x += dx)
            {
                Console.WriteLine("x = {0}\tf(x) = {1}", x, del(x));
            }
        }

        //Метод для нахождения количества точек в заданном диапозоне, для которых выполняется определённое условие
        public static int DotCount(double a, double b, double dx, F del, option opt)
        {
            int k = 0;
            for (double x = a; x <= b; x += dx)
            {
                if (opt(del(x))) k++;
            }
            return k;
        }

        //Метод для нахождения максимального и минимального значения для массива элементов
        public static void MaxMin(int n, F del)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            Console.Write("Набор точек: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            double maxElem = del(arr[0]);
            double minElem = del(arr[0]);
            foreach (int elem in arr)
            {
                if (maxElem < elem)
                    maxElem = elem;
                if (minElem > elem)
                    minElem = elem;
            }
            Console.WriteLine($"\nМаксимальное значение: {maxElem}");
            Console.WriteLine($"Минимальное значение: {minElem}");
        }
    }
}
