using System;

namespace practice_2_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] a = new double[] { -8, 13, 26, 14, 17, 21, -34, 28 };
            int n = a.Length;
            string str;
            int i;
            double sum = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            double avg;
            avg = sum / n;
            str = "Сумма массива равна " + sum + "\nСреднее арифметическое массива равно  " + avg;
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}