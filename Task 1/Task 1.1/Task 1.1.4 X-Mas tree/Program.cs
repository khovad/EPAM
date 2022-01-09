using System;

namespace Task_1._1._4_X_Mas_tree
{
    class Program
    {
        static void Triangle(int N, int s)
        {
            for (int i = 1; i <= s; i++)
            {
                int k = 2 * i - 1;
                for (int j = N - i; j > 0; j--)
                    Console.Write(" ");
                while (k > 0)
                {
                    Console.Write("*");
                    k--;
                }
                Console.WriteLine();

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                
                Triangle(N, i);
                
            }
        }
    }
}
