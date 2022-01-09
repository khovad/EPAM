using System;

namespace Task_1._2._3_Lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи текст");
            var Sentence = Console.ReadLine();
            int i = 0;

            char[] separaters = new char[] { ' ', '.', ':', ';', '?', '!', ',' };
            string[] words = Sentence.Split(separaters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
                if (word[0] != word.ToUpper()[0])
                   i++;

            Console.WriteLine("Количество слов:" + i);
        }
    }
}
