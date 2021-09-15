using System;

//Создание динамического массива
namespace TRPOLesson
{
    public class Practice_2_3
    {
        public static void Exercise()
        {
            // создаем массив размером 8 и обьявляем переменные
            double[] a = new double[] { -8, 13, 26, 14, 17, 21, -34, 28 };
            int n = a.Length;
            string str;
            int i;
            double sum = 0;
            //перебираем массив и суммируем все значения массива
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            //вычисляем средную арифметическую и обьявляем переменную для этого
            double avg;
            avg = sum / n;
            str = "Сумма массива равна " + sum + "\nСреднее арифметическое массива равно  " + avg;
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}