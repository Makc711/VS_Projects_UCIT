using System;
using System.Collections.Generic;

namespace Task_2_6
{
    class Program
    {
        static void Main()
        {
            char[][] arr =
            {
                new[]{'м','о','к','л'},
                new[]{'а','и','о','р'},
                new[]{'о','й','н','о'},
                new[]{'г','а','п','с'}
            };

            string word = "молоко";
            Console.WriteLine(IsWordCorrectly(word, arr) ? "Можно" : "Нельзя");
            Console.ReadKey();
        }

        public static bool IsWordCorrectly(string word, char[][] alphabet)
        {
            if (word.Length > alphabet.Length * alphabet[0].Length)
                return false;
            var dictionaryForWord = new Dictionary<char, int>(word.Length);
            var dictionaryForAlphabet = new Dictionary<char, int>(alphabet.Length * alphabet[0].Length);
            foreach (var c in word) 
            {
                if (dictionaryForWord.ContainsKey(c))
                    dictionaryForWord[c]++;
                else
                    dictionaryForWord.Add(c, 1);
            }
            foreach (var i in alphabet) 
            {
                foreach (var c in i) 
                {
                    if (dictionaryForAlphabet.ContainsKey(c))
                        dictionaryForAlphabet[c]++;
                    else
                        dictionaryForAlphabet.Add(c, 1);
                }
            }
            foreach (var field in dictionaryForWord)
            {
                if (!dictionaryForAlphabet.TryGetValue(field.Key, out var value) || value < field.Value)
                    return false;
            }
            return true;
        }
    }
}
