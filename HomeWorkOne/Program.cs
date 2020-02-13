using System;

namespace HomeWorkOne
{
    internal static class Program
    {
        static double Distance(double x1, double x2, double y1, double y2)
        {
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static void PrintCenter(string msg)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(msg);
        }
        
        public static void Main(string[] args)
        {
            // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            Console.WriteLine("Программа Анкета\n");
            Console.WriteLine("Введите ваше имя\n");
            var name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            var secName = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах (Пример 1,8)");
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес");
            var weight = double.Parse(Console.ReadLine());
  
            // а) используя  склеивание;
            // б) используя форматированный вывод;
            // в) используя вывод со знаком $.
            
            Console.WriteLine("Ваше имя: " + name + " Фамилия: " + secName + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Ваше имя {0}, Фамилия {1}, Возраст {2}, Рост {3}, Вес {4}", name, secName, age, height, weight);
            Console.WriteLine($"Ваше имя {name}, Фамилия {secName}, Возраст {age}, Рост {height}, Вес {weight}");

            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Вычисление индекса массы тела\n");
            double imt = weight / (Math.Pow(height, 2));
            Console.WriteLine($"Индекс массы тела = {imt:F}");

            // Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)).
            // Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

            Console.WriteLine("Подсчет расстояния между точками\n");
            Console.WriteLine("Найти расстояние между двумя точками");
            Console.WriteLine("Координаты первой точки:\nX и Y\n");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var x2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Координаты второй точки:\nX и Y\r");
            var y1 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Расстояние между точками = {Distance(x1,x2,y1,y2):F}");

            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;
            Console.WriteLine("Обмен значениями\n");

            int a1 = 5;
            int b1 = 7;
            int c = b1;
            b1 = a1;
            a1 = c;
            Console.WriteLine($"a1 = {a1}, b1 = {b1}");


            // б) *без использования третьей переменной.
            int a = 10;
            int b = 15;
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}, b = {b}");

            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) *Сделать задание, только вывод организовать в центре экрана.
            // в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y)).

            Console.WriteLine("Программа с выводом в центре консоли\n");

            Print("Введите ваше имя\n");
            var name2 = Console.ReadLine();

            Print("Введите вашу фамилию");
            var secName2 = Console.ReadLine();

            Print("Введите ваш город");
            var city = Console.ReadLine();

            PrintCenter($"Имя: {name2}, Фамилия: {secName2}, Город: {city}");
        }
    }
}