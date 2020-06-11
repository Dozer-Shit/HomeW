using System;

// Исполнитель Шитов Евгений
namespace Algorithms_Lesson1
{
    internal class Program
    {
        private static void Pause()
        {
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

        // Написать функцию нахождения максимального из четырех чисел.
        private static double MaxNumber(double a, double b, double c, double d)
        {
            return Math.Max(a, Math.Max(b, Math.Max(c, d)));
        }
        
        public static void Main(string[] args)
        {
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Введите ваш рост в метрах (Пример 1,8)");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес");
            var weight = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Вычисление индекса массы тела\n");
            double imt = weight / (Math.Pow(height, 2));
            Console.WriteLine($"Индекс массы тела = {imt:F}");
            Pause();
            
            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;
            
            Console.WriteLine("Обмен значениями\n");

            int a1 = 5;
            int b1 = 7;
            Console.WriteLine($"До a = {a1}, b = {b1}");
            int c = b1;
            b1 = a1;
            a1 = c;
            Console.WriteLine($"После a = {a1}, b = {b1}\n");


            // б) *без использования третьей переменной.
            int a = 10;
            int b = 15;
            Console.WriteLine($"До a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"После a = {a}, b = {b}");
            Pause();
            
            // Найти максимальное из четырех чисел. Массивы не использовать.
            
            Console.WriteLine("Введите 4 числа\n");
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            var num4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Минимальное число - {MaxNumber(num1, num2, num3, num4)}");
            Pause();
        }
    }
}