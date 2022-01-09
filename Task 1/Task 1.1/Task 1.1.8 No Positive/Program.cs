using System;

namespace Task_1._1._8_No_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во столбцов: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Кол-во строк: ");
            int N;
            int.TryParse(Console.ReadLine(), out N);

            Console.WriteLine("Кол-во слоев: ");
            int K;
            int.TryParse(Console.ReadLine(), out K);

            Console.WriteLine("Массив Трехмерный");

            int[,,] array = new int[N, n, K];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < K; k++)
                    {
                        array[i, j, k] = rand.Next(-50, 50);
                        Console.Write("{0,4}", array[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < K; k++)
                    {
                        Console.WriteLine("Элемент массива: [" + i + "," + j + "]" + " = " + array[i, j, k]);
                        if (array[i, j, k] > 0)
                        {
                            Console.WriteLine("Элемент - положительный. Значение меняется на <0>");
                            array[i, j, k] = 0;
                        }
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < K; k++)
                    {
                            Console.Write("{0,4}", array[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
