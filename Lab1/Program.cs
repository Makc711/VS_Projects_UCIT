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

        public static void Swap(int[][] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++) 
            {
                for (int j = 0; j < arr[i].Length; j++) 
                {
                    int temp = arr[i][j];
                    arr[i][j] = arr[arr.Length - 1 - i][j];
                    arr[arr.Length - 1 - i][j] = temp;
                }
            }
        }
    }
}
