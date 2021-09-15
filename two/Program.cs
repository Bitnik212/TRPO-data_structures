using System;

// просто ходим в двумерном массиве
// можно искать симвл в строке либо если немного дописать то строку в подстроке
namespace two
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] strings = {"Москва", "Америка", "USA", "Russia"};
            string str = "";
            foreach (var s in strings)
            {
                for (var i = 0; i < s.Length; i++)
                {
                    str += s[i];
                }
                str += "\n";
            }

            Console.WriteLine(str);
        }
    }
}