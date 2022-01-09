using System;

namespace Task_1._1._10_2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во столбцов: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Колв-во строк: ");
            int N;
            int.TryParse(Console.ReadLine(), out N);
            int sum = 0;
            int[,] array = new int[N,n];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i,j] = rand.Next(-50, 50);
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Элемент массива: [" + i + ","+ j +"]" );
                    if ((j + i) % 2 == 0)
                    {
                        Console.WriteLine("Элемент равен: " + array[i,j]);
                        sum = sum + array[i, j];
                        Console.WriteLine("Промежуточная сумма четных элементов: " + sum);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Итоговая сумма четных элементов: " + sum);
        }
    }
}
