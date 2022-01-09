using System;

namespace Task_1._1._9_Non_negative_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(-50, 50);
                Console.WriteLine("Элемент массива " + i + " = " + array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (array[i] >= 0)
                    sum = sum + array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма неотрицательных элементов: " + sum);
        }
    }
}
