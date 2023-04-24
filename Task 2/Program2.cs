using Task_2;

internal class Program2:Functions2
{
    private static void Main(string[] args)
    {
        StrOpt opt;
        Console.Write("Введите количество строк в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] str = new string[n];
        Console.WriteLine("Введите строки:");
        for (int i = 0; i < str.Length; i++)
        {
            str[i] = Console.ReadLine();
        }
        opt = taskA1;
        Console.WriteLine($"Количество строк в которых нет заглавных букв: {StrCount(str, opt)}");
        opt = taskA2;
        Console.WriteLine($"Количество строк-палиндромов: {StrCount(str, opt)}");
        opt = taskB1;
        Console.WriteLine($"Количество дясетисимвольных строк: {StrCount(str, opt)}");
        opt = taskC1;
        Console.WriteLine("Все слова, начинающиесяна букву ‘W’ вэтомнаборе:");
        PrintStr(str, opt);
        opt = taskC2;
        Console.WriteLine("Все составные слова, включащие дефис:");
        PrintStr(str, opt);
    }
}