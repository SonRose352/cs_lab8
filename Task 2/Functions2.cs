using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Functions2
    {
        //Делегаты 
        public delegate bool StrOpt(string str);

        public static bool taskA1(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i])) return false;
            }
            return true;
        }

        public static bool taskA2(string str)
        {
            for (int i = 0; i <= str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i]) return false;
            }
            return true;
        }

        public static bool taskB1(string str)
        {
            if (str.Length == 10) return true;
            else return false;
        }

        public static bool taskC1(string str)
        {
            if (str[0] == 'W') return true;
            else return false;
        }

        public static bool taskC2(string str)
        {
            foreach (char c in str)
            {
                if (c == '-') return true;
            }
            return false;
        }

        //Методы для подсчёта количества определённых строк
        public static double StrCount(string[] str, StrOpt opt)
        {
            int k = 0;
            foreach (string s in str)
            {
                if (opt(s)) k++;
            }
            return k;
        }

        public static void PrintStr(string[] str, StrOpt opt)
        {
            for (int i = 0; i < str.Length; i++)
            {
                string[] strings = str[i].Split(new char[] { ' ' });
                foreach (string s in strings)
                {
                    if (opt(s))
                        Console.WriteLine(s);
                }
            }
        }
    }
}
