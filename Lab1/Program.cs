using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            int[][] arr =
            {
                new[]{1,2,3},
                new[]{4,5,6},
                new[]{7,8,9},
                new[]{10,11,12}
            };

            Show(arr);
            Swap(arr);
            Console.WriteLine();
            Show(arr);

            Console.ReadKey();
        }

        public static void Show(int[][] arr)
        {
            foreach (var i in arr) 
            {
                foreach (var j in i) {
                    Console.Write($"{j,4}");
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
