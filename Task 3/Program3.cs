using Task_3;

internal class Program3:Functions3
{
    private static void Main(string[] args)
    {
        F func;
        func = taskA;
        Console.WriteLine($"Корень функции A): {FindRoot(0, Math.PI, func)}");
        func = taskBC;
        Console.WriteLine($"Корень функции B): {FindRoot(0, 0.9, func)}");
        Console.WriteLine($"Корень функции C): {FindRoot(2.1, 5, func)}");
        func = taskD;
        Console.WriteLine($"Корень функции D): {FindRoot(Math.PI, 2 * Math.PI, func)}");
    } 
}