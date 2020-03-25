using System;

namespace HomeWork4
{
    internal static class Program
    {
        private static int Rand()
        {
            var ran = new Random();
            var rand = ran.Next(-10000, 10000);
            return rand;
        }

        private static int[] RandArray()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Rand();
            }

            return arr;
        }

        private static int Pair(int[] arrey)
        {
            int counter = 0;
            for (int i = 0; i < arrey.Length - 1; i++)
            {
                if (arrey[i] % 3 == 0 && arrey[i + 1] % 3 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void Main(string[] args)
        {
            int[] a;
            a = RandArray();
            int b = Pair(a);
            Console.WriteLine($"Пар элементов массива делящихся на 3: {b}");
        }
    }
}