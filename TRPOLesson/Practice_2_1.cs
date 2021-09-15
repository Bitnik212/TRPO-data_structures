using System;

//Нахождение суммы массива
namespace TRPOLesson
{
    public class Practice_2_1
    {
        public static void Exercise()
        {
            int n = 3;
            int[] a = new int[n]; // создаем массив размером n (3)
            string str;
            int i;
            //заполняем массив
            a[0] = 1;
            a[1] = -8;
            a[2] = 14;

            int sum = 0;
            //перебираем массив и считаем его сумму
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            //выводим в консоль
            str = "Сумма массива равна " + sum;
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}