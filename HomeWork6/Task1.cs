using System;
// Для пулл реквеста
namespace HomeWork6
{
    public class Task1
    {
        public static void Table(Fun f, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, f(x, b));
                x += 1;
            }

            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        public static double MyFunc2(double x, double a)
        {
            return a * Math.Sin(x);
        }
    }
}