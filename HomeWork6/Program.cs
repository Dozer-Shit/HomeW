using System;
using System.Collections.Generic;
using System.IO;
using static HomeWork6.Task1;
using static HomeWork6.Task2;
using static HomeWork6.Student;

namespace HomeWork6
{
    public delegate double Fun(double x, double a);

    public delegate double Fun2(double x);

    internal static class Program
    {
        public static void Main(string[] args)
        {
            //  Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double).
            // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).


            Console.WriteLine("Таблица функции MyFunc:");


            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");

            Table(MyFunc2, -2, 2);

            Console.WriteLine("Таблица функции x^2:");

            Table(delegate(double x, double a) { return a * Math.Pow(x, 2); }, 0, 3);

            // Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            // а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
            // б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
            // в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
            // возвращает минимум через параметр.

            Fun2[] delegateFun = {F1, F2};
            Console.WriteLine("Сделайте выбор: 1 - функция F1, 2 - функция F2");
            int index = int.Parse(Console.ReadLine()) - 1;
            SaveFunc("data.bin", -100, 100, 0.5, delegateFun[index]);
            double minimum = 0;
            Load("data.bin", ref minimum);
            Console.WriteLine(minimum);
            Console.ReadKey();

            // Переделать программу «Пример использования коллекций» для решения следующих задач:
            // а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            // б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
            // в) отсортировать список по возрасту студента;
            // г) *отсортировать список по курсу и возрасту студента;
            // д) разработать единый метод подсчета количества студентов по различным параметрам
            // выбора с помощью делегата и методов предикатов.


            int magistr = 0;
            int bakalavr = 0;
            List<Student> list = new List<Student>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("students_1.csv");
                string temp = "";
                while (!sr.EndOfStream)
                {
                    try
                    {
                        temp = sr.ReadLine();
                        string[] param = temp.Split(';');
                        Student t = new Student(param[0], param[1], param[2], param[3], param[4], int.Parse(param[5]), Convert.ToInt32(param[6]),
                            int.Parse(param[7]), param[8]);
                        list.Add(t);
                        if (t.Course < 5)
                        {
                            bakalavr++;
                        }
                        else
                        {
                            magistr++;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(temp);
                    }
                }
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            Console.WriteLine($"Всего студентов: {list.Count}");
            Console.WriteLine($"Учащихся на 5 и 6 курсах (магистров): {magistr}");

            List<Student> list2 = list;

            list2.Sort(SortByAgeAndCourse);

            list.Sort(SortAge);
            list.Sort(SortCourse);

            CalcStud(list);
            Console.ReadKey();
        }
    }
}