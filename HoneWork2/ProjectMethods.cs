using System;

namespace HomeWorkTwo
{
    public class ProjectMethods
    {
        // Написать метод, возвращающий минимальное из трёх чисел.
        public static double MinNumber(double a, double b, double c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        // Написать метод подсчета количества цифр числа.
        public static long NumCount(long a)
        {
            return (long) (Math.Log10(a) + 1);
        }

        //Реализовать метод проверки логина и пароля.
        public static void CheckUser(string pass, string passAnsw, string log, string logAnsw, int count)
        {
            do
            {
                logAnsw = Console.ReadLine();
                passAnsw = Console.ReadLine();
                if (logAnsw == log && passAnsw == pass)
                {
                    Console.WriteLine("Вы успешно прошли авторизацию");
                    break;
                }

                if (count == 0)
                {
                    Console.WriteLine("У вас не осталось попыток, обратитесь в службу поддержки");
                    return;
                }

                Console.WriteLine(
                    $"Логин или пароль не совпадают, попробуйте повторить попытку\nУ вас осталось {count} попыток");
                count--;
            } while (logAnsw != log || passAnsw != pass);
        }

        public static void PrintBIM(string text, double bim)
        {
            Console.WriteLine($"Индекс массы вашего тела = {bim:F1} это означает, что у вас {text}");
        }

        //Подсчет индекса массы тела
        public static double BIM(double weight, double height)
        {
            double bim = weight / (Math.Pow(height, 2));
            return bim;
        }

        // Распределение рекомендаций относительно роста
        public static void Recommendation(double weight, double height, double bim)
        {
            if (height > 1.44d && height < 1.60d)
            {
                Usl(50, bim, weight);
            }
            else if (height > 1.60d && height < 1.81d)
            {
                Usl(60, bim, weight);
            }
            else if (height > 1.80d && height < 2.05d)
            {
                Usl(80, bim, weight);
            }
        }

        // Сама рекомендация
        private static void Usl(int num, double bim, double weight)
        {
            Console.WriteLine($"Для вас оптимальным весом будет {num} Кг");
            if (bim > 24)
            {
                Console.WriteLine($"Вам необходимо сбросить {weight - num} Кг");
            }
            else if (bim < 19)
            {
                Console.WriteLine($"Вам необходимо набрать {num - weight} Кг");
            }
        }

        // Проверка на число
        public static void ParseNum(bool pars, out double param)
        {
            double value = 0;
            while (pars == false)
            {
                Console.WriteLine("Можно вводить только положительные числа");
                pars = double.TryParse(Console.ReadLine(), out value);
            }

            param = value;
        }

        // Рекурсивный метод вывода чисел от a до b (Не включая a и b)
        public static void Recursion(int a, int b)
        {
            if (a == b - 1)
            {
                return;
            }

            a++;
            Console.WriteLine(a);
            Recursion(a, b);
        }

        // Рекурсивный метод сложения чисел от a до b (Арифметическая прогрессия)

        public static int Recursion(int a, int b, int c)
        {
            if (a > b)
            {
                return c;
            }

            c += a;
            a++;

            return Recursion(a, b, c);
        }

        // Сумма числа
        public static int Sum(int num)
        {
            int counter = 0;
            while (num != 0)
            {
                counter += num % 10;
                num /= 10;
            }

            return counter;
        }
    }
}