using System;

namespace Task_1._2._1_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи текст");
            var Sentence = Console.ReadLine();
            int i = 0, l = 0;
            char[] separaters = new char[] { ' ', '.', ':' };
            string[] words = Sentence.Split(separaters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                l += word.Length;
                i++;
            }
            Console.WriteLine(l / i);
        }
    }
}
