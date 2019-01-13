using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2_6
{
    class Program
    {
        static void Main()
        {
            char[,] alphabet =
            {
                {'м','о','к','л'},
                {'а','и','о','р'},
                {'о','й','н','о'},
                {'г','а','п','с'}
            };

            string word = "крокодил";
            Console.WriteLine("Алфавит:");
            Show(alphabet);
            Console.WriteLine("Слово: " + word);
            Console.WriteLine(IsWordCorrectly(word, alphabet) ? "Можно" : "Нельзя");
            Console.ReadKey();
        }

        public static void Show(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write($"{array[i, j],2}");
                }
                Console.WriteLine();
            }
        }

        public static bool IsWordCorrectly(string word, char[,] alphabet)
        {
            if (word.Length > alphabet.Length)
                return false;
            var dictionaryForWord = DictionaryOfLetters(word.ToCharArray());
            var dictionaryForAlphabet = DictionaryOfLetters(alphabet.Cast<char>().ToArray());
            foreach (var field in dictionaryForWord)
            {
                if (!dictionaryForAlphabet.TryGetValue(field.Key, out var value) || value < field.Value)
                    return false;
            }
            return true;
        }

        private static Dictionary<char, int> DictionaryOfLetters(char[] array)
        {
            var dictionary = new Dictionary<char, int>(array.Length);
            foreach (var letter in array)
            {
                if (dictionary.ContainsKey(letter))
                    dictionary[letter]++;
                else
                    dictionary.Add(letter, 1);
            }
            return dictionary;
        }
    }
}
