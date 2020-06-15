using System;

namespace Algorithms_Lesson2
{
    internal class Program
    {
        static string Recursion(int i)
        {
            return (i == 0) ? "0" : Recursion2(i);
        }

        //  Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
        static string Recursion2(int i)
        {
            return (i > 0) ? Recursion2(i / 2) + (i % 2) : "";
        }

        // Реализовать функцию возведения числа a в степень b:
        
        //b. рекурсивно;
        static double Pow(int value, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            
            if (pow > 0)
            {
                return Pow(value, pow - 1) * value;
            }
            
            return 1.0 / Pow(value, -pow);
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите десятичное число: ");
            Console.WriteLine(Recursion(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();

            Console.Write("Введите число: ");
            var i1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите степень: ");
            var i2 = Convert.ToInt32(Console.ReadLine());
            
            var result = Pow(i1, i2);
            Console.WriteLine(result);

            // a. без рекурсии;
            
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Введите степень: ");
            int n = int.Parse(Console.ReadLine());
            int numN = 1;

            for (int i = 0; i < n; i++)
            {
                numN *= num;
            }

            Console.WriteLine($"{num} ^ {n} = {numN}");
            Console.ReadKey();
        }
    }
}