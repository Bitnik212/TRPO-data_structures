using System;

//Многомерные массива (Герберт Шилдт)
namespace TRPOLesson
{
    public class Practice_2_4
    {
        public static void Exercise()
        {
            int t, i;
            int[,] table = new int[3, 4]; //создаем двумерный массив размером 3 и 4
            //перебираем двумерный массив, заполняем его и выводим его
            for (t = 0; t < 3; ++t)
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.WriteLine(table[t, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}