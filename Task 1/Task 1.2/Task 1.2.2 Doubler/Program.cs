using System;

namespace Task_1._2._2_Doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            string FinalString = "";
            Console.WriteLine("Введи первую строку");
            var IString = Console.ReadLine();
            Console.WriteLine("Введи вторую строку");
            var IIString = Console.ReadLine();

            foreach (char ch in IString)
                if (!IIString.Contains(ch))
                    FinalString += ch;
                else
                {
                    FinalString += ch;
                    FinalString += ch;
                }
            Console.WriteLine("Итоговая строка = {0}", FinalString);
        }
    }
}
