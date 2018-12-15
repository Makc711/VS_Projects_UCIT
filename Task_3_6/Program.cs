using System;
using System.Text.RegularExpressions;

namespace Task_3_6
{
    class Program
    {
        static void Main()
        {
            string text = "Задан текст. Определить, содержит ли он цифры?";

            Console.WriteLine(IsTextContainNumber(text) ? "да" : "нет");
            Console.ReadKey();
        }

        public static bool IsTextContainNumber(string text)
        {
            Regex pat = new Regex(@"[0-9]");
            Match match = pat.Match(text);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
