using System;

namespace Task_1._2._4_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи текст");
            var Sentence = Console.ReadLine();
            char[] c = Sentence.ToCharArray();
            c[0] = char.ToUpper(c[0]);
            for (int i = 0; i < c.Length - 2; i++)
                if (c[i] == '.' || c[i] == '?' || c[i] == '!')
                    c[i + 2] = char.ToUpper(c[i + 2]);

            Console.WriteLine(c);

        }
    }
}
