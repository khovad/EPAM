using System;

namespace Task_1._1._1_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out b);
            if ( a >0 && b > 0)
            {
                Console.WriteLine("Длина: {0}, Ширина: {1}, Площадь = {2}", a, b, a * b);
            }
            else
            {
                Console.WriteLine("Ошибка. Неверные данные.");
            }
        }
    }
}
