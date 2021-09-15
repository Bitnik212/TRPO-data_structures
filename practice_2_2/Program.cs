using System;

namespace practice_2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 5;
            string[] a = new string[n];
            string str;
            int i;
            a[0] = "Миссисипи";
            a[1] = "Нил";
            a[2] = "Амазонка";
            a[3] = "Енисей";
            a[4] = "Белая";

            str = "";

            for (i = 0; i < n; i++)
            {
                str += a[i] + "\n";
            }

            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}