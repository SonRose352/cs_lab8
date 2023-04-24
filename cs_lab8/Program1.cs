using cs_lab8;
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program1:Functions1
{
    private static void Main(string[] args)
    {
        F del;
        ////Функция a)
        //PrintFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Math.Cos);

        ////Функция b)
        //del = taskB;
        //PrintFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, del);

        ////Функция c)
        //del = taskC;
        //PrintFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, del);

        ////Функция d)
        //del = x =>
        //{
        //    double y = 0;
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        y += Math.Pow(x / (Math.PI * i) - 1, 2);
        //    }
        //    return y;
        //};
        //PrintFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, del);

        ////Функция e)
        //Func<double, double> func = taskE;
        //PrintResult(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, func);

        //Обработка всех функций одним циклом
        F[] massivSsilok = new F[5] { Math.Cos, taskB, taskC, taskD, taskE };
        foreach (F ssilka in massivSsilok)
        {
            PrintFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, ssilka);
        }

        //Проверка функций условия
        option opt;
        int k1 = 0;
        int k2 = 0;
        for (int i = 0; i < 5; i++)
        {
            del = massivSsilok[i];
            opt = opt1;
            Console.WriteLine($"\nКоличество отрицательных значений для функции {del.Method.Name}: {DotCount(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, del, opt)}");
            k1 += DotCount(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, del, opt);
            opt = opt2;
            Console.WriteLine($"Количество значений функции {del.Method.Name}, входящих в промежуток [-1, 1]: {DotCount(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, del, opt)}");
            k2 += DotCount(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, del, opt);
        }
        Console.WriteLine($"Общее число отрицательных значений для всех функций: {k1}");
        Console.WriteLine($"Общее число значений, входящих в промежуток [-1, 1] для всех функций: {k2}");

        //Нахождение максимального и минимального значения для каждой из функций
        for (int i = 0; i < 5; i++)
        {
            del = massivSsilok[i];
            Console.WriteLine($"\nМаксимальное и минимальное значения для функции {del.Method.Name} :");
            MaxMin(10, del);
        }
    }
}