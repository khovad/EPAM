using System;

namespace Task_1._1._5_Sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) 
                sum = sum + i;
            }
            Console.WriteLine("Сумма всех чисел меньше 1000, кратных 3 или 5: {0} ", sum);
        }
    }
}
