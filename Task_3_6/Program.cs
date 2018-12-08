using System;

namespace Task_3_6
{
    class Program
    {
        static void Main()
        {
            string text = "Задан текст. Определить,содержит ли он цифры?";

            Console.WriteLine(IsTextContainNumber(text) ? "да" : "нет");
            Console.ReadKey();
        }

        public static bool IsTextContainNumber(string text)
        {
            foreach (var c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
