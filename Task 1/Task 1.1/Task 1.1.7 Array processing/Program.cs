using System;

namespace Task_1._1._7_Array_processing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int max = 0;
            int min = 0;
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(-50,50);
                Console.WriteLine("Элемент массива " + i + " = " + array[i]);
            }
            min = array[0];
            max = array[0];
            for (int i = 1; i < N; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);
        }
    }
}
