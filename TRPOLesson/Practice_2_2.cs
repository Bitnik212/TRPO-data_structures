using System;

//Отображение символьного массива
namespace TRPOLesson
{
    public class Practice_2_2
    {
        public static void Exercise()
        {
            int n = 5;
            string[] a = new string[n]; // создаем массив размером n 
            string str;
            int i;
            //заполняем массив
            a[0] = "Миссисипи";
            a[1] = "Нил";
            a[2] = "Амазонка";
            a[3] = "Енисей";
            a[4] = "Белая";

            str = "";
            //перебираем массив и конкатенируем в одну строку
            for (i = 0; i < n; i++)
            {
                str += a[i] + "\n";
            }
            //выводим в консоль
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}