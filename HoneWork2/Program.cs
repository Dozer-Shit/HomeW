using System;
using System.Collections.Generic;
using System.Threading;


namespace HomeWorkTwo
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа\n");
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Минимальное число - {ProjectMethods.MinNumber(num1, num2, num3)}");

            Console.WriteLine("Введите число для подсчета цифр в нем");
            var num4 = long.Parse(Console.ReadLine());

            Console.WriteLine($"Кол-во цифр в числе - {ProjectMethods.NumCount(num4)}");

            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.WriteLine("Введите числа для подсчета суммы нечетных, 0 останавливает ввод");
            var num = 0;
            var sum = 0;
            bool parsed;
            string allNums = "";
            List<int> numbers = new List<int>();

            do
            {
                parsed = int.TryParse(Console.ReadLine(), out num);
                while (parsed == false)
                {
                    Console.WriteLine("Можно вводить только положительные числа");
                    parsed = int.TryParse(Console.ReadLine(), out num);
                }

                if (num % 2 != 0)
                {
                    sum += num;
                    numbers.Add(num);
                }
                else if (num > 0 && num % 2 == 0)
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Можно вводить только положительные числа");
                }
            } while (num != 0);

            for (int i = 0; i < numbers.Count; i++)
            {
                allNums += Convert.ToString(numbers[i]) + " ";
            }

            Console.WriteLine($"Вы ввели числа: {allNums}\nСумма нечетных чисел составляет: {sum}");

            //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина,
            //если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

            Console.WriteLine("Программа эмуляции авторизации.\n\nУстановите ваш логин и затем пароль");
            string login = Console.ReadLine();
            string password = Console.ReadLine();
            Console.WriteLine("Отлично ! Ваши данные сохранены\nТеперь вам необходимо авторизоваться\nВведите ваши логин и пароль");

            string loginAnsw = "";
            string passwordnAnsw = "";
            int counter = 3;
            ProjectMethods.CheckUser(password, passwordnAnsw, login, loginAnsw, counter);

            // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Теперь мы узнаем, в норме ли ваш вес\nВведите ваш рост (в метрах) :");
            double height;
            double weight;
            bool hInput = double.TryParse(Console.ReadLine(), out height);

            if (hInput == false)
            {
                ProjectMethods.ParseNum(hInput, out height);
            }

            Console.WriteLine("Теперь вес :");
            bool wInput = double.TryParse(Console.ReadLine(), out weight);

            if (hInput == false)
            {
                ProjectMethods.ParseNum(wInput, out weight);
            }

            var bim = ProjectMethods.BIM(weight, height);
            if (bim < 20 && bim > 18)
            {
                ProjectMethods.PrintBIM("недостаток веса", bim);
            }
            else if (bim > 20 && bim < 25)
            {
                ProjectMethods.PrintBIM("показатели в норме", bim);
            }
            else if (bim > 25 && bim < 30)
            {
                ProjectMethods.PrintBIM("избыточный вес", bim);
            }
            else if (bim > 30)
            {
                Console.WriteLine(
                    $"Индекс массы вашего тела = {bim:F1} это означает, что пора выбирать для себя ящик и пошире");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так попробуйте повторить ввод данных");
            }

            // a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cout = 0;
            Console.WriteLine("Вывод всех чисел от а до б");
            ProjectMethods.Recursion(a, b);
            Console.WriteLine($"Сумма чисел от а до б {ProjectMethods.Recursion(a, b, cout)}");

            // *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
            // Хорошим называется число, которое делится на сумму своих цифр.
            // Реализовать подсчет времени выполнения программы, используя структуру DateTime.

            DateTime start = DateTime.Now;
            var goodNum = new List<long>();

            for (int i = 2014; i < 1000000000; i++)
            {
                if (i % ProjectMethods.Sum(i) == 0)
                {
                    goodNum.Add(i);
                }
            }

            Console.WriteLine($"Хороших чисел - {goodNum.Count}\nПодсчитано за {DateTime.Now - start}");
        }

        
    }
}