using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            int[][] array =
            {
                new[]{1,2,3},
                new[]{4,5,6},
                new[]{7,8,9},
                new[]{10,11,12}
            };

            Show(array);
            Swap(array);
            Console.WriteLine();
            Show(array);

            Console.ReadKey();
        }

        public static void Show(int[][] array)
        {
            foreach (var innerArray in array) 
            {
                foreach (var item in innerArray) {
                    Console.Write($"{item,4}");
                }
                Console.WriteLine();
            }
        }

        public static void Swap(int[][] array)
        {
            for (int i = 0; i < array.Length / 2; i++) 
            {
                for (int j = 0; j < array[i].Length; j++) 
                {
                    int temp = array[i][j];
                    array[i][j] = array[array.Length - 1 - i][j];
                    array[array.Length - 1 - i][j] = temp;
                }
            }
        }
    }
}
