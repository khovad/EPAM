using System;

namespace Task_1._1._3_Another_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: "); 
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int k = 2*i-1;
                for (int j = N-i; j > 0; j--)
                    Console.Write(" ");   
                while (k > 0)
                {
                    Console.Write("*");
                    k--;
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}