using System;
using System.Collections.Generic;

struct Complex
{
    public double im;

    public double re;

    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }

    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    public Complex Substuct(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public string ToStr()
    {
        if (im < 0)
        {
            return re + "+" + -im + "i";
        }

        return re + "+" + im + "i";
    }
}

class ComplexCl
{
    public double im;
    public double re;

    public ComplexCl PlusCl(ComplexCl x2)
    {
        ComplexCl x3 = new ComplexCl();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }

    public ComplexCl SubstuctCl(ComplexCl x2)
    {
        ComplexCl x3 = new ComplexCl();
        x3.im = im - x2.im;
        x3.re = re - x2.re;
        return x3;
    }

    public ComplexCl MultiCl(ComplexCl x2)
    {
        ComplexCl x3 = new ComplexCl();
        x3.im = re * x2.im + im * x2.re;
        x3.re = re * x2.re - im * x2.im;
        return x3;
    }

    public string ToStri()
    {
        if (im < 0)
        {
            return re + "+" + -im + "i";
        }

        return re + "+" + im + "i";
    }
}

namespace HomeWork3
{
    internal class Program
    {
        public static void Print(string text, Fraction c)
        {
            Fraction.Reduction(c);
            var intPart = Fraction.IntPart(c);
            Console.WriteLine($"{text} дробей: {intPart.Item1}|{intPart.Item2.Numerator}/{intPart.Item2.Denominator}");
        }

        public static void Main(string[] args)
        {
            // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;

            Console.WriteLine("Демонстрация структуры комплексных чисел");
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;


            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToStr());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToStr());
            result = complex1.Substuct(complex2);
            Console.WriteLine(result.ToStr());

            // б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

            Console.WriteLine("Демонстрация класса комплексных чисел");

            ComplexCl complex3 = new ComplexCl {re = 1, im = 1};

            ComplexCl complex4 = new ComplexCl {re = 2, im = 2};

            ComplexCl results = complex3.PlusCl(complex4);
            Console.WriteLine(results.ToStri());
            results = complex3.SubstuctCl(complex4);
            Console.WriteLine(results.ToStri());
            results = complex3.MultiCl(complex4);
            Console.WriteLine(results.ToStri());

            //а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
            //Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
            //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
            //При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

            Console.WriteLine("Программа подсчета суммы всех нечетных положительных чисел");
            Console.WriteLine("Введите числа для подсчета суммы нечетных, 0 останавливает ввод\n");
            var num = 0;
            var sum = 0;
            string allNums = "";
            List<int> numbers = new List<int>();

            do
            {
                var parsed = int.TryParse(Console.ReadLine(), out num);
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
            } while (num != 0);

            for (int i = 0; i < numbers.Count; i++)
            {
                allNums += Convert.ToString(numbers[i]) + " ";
            }

            Console.WriteLine($"Вы ввели числа: {allNums}\nСумма нечетных чисел составляет: {sum}\n");

            // *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
            // Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу,
            // демонстрирующую все разработанные элементы класса.
            // ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
            // ArgumentException("Знаменатель не может быть равен 0");
            // Добавить упрощение дробей.

            Console.WriteLine("Представление работы класса с операциями над дробями\n");

            Fraction a = new Fraction();
            Fraction b = new Fraction();
            do
            {
                Console.WriteLine("Введите числитель и знаменатель первой дроби");
                try
                {
                    a = new Fraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception message)
                {
                    Console.WriteLine(message);
                }
            } while (a.Denominator == 0);

            do
            {
                Console.WriteLine("Введите числитель и знаменатель второй дроби");
                try
                {
                    b = new Fraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception message)
                {
                    Console.WriteLine(message);
                }
            } while (b.Denominator == 0);

            Console.WriteLine("Результаты операций над над дробями. Формат Целая часть | Дробная часть\n");
            Fraction c = Fraction.Addition(a, b);
            Print("Сложение", c);
            c = Fraction.Subtraction(a, b);
            Print("Вычетание", c);
            c = Fraction.Multiplication(a, b);
            Print("Умножение", c);
            c = Fraction.Division(a, b);
            Print("Деление", c);
        }
    }
}