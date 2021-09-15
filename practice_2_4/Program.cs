using System;

namespace practice_2_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int t, i;
            int[,] table = new int[3, 4];
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