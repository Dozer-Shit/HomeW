using System;
using System.IO;

// Сделано
namespace HomeWork4
{
    class MyArray
    {
        private readonly int[] _arr;

        public MyArray(int n, int start, int step)
        {
            _arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                _arr[i] = start + step * i;
            }
        }


        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < _arr.Length; i++)
                {
                    sum += _arr[i];
                }

                return sum;
            }
        }

        public void Inverse()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] *= -1;
            }
        }

        public void Multi(int x)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] *= x;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = _arr[0];
                int count = 1;
                for (int i = 1; i < _arr.Length; i++)
                {
                    if (_arr[i] > max)
                    {
                        max = _arr[i];
                        count = 1;
                    }
                    else if (_arr[i] == max)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public void Print()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.Write("{0} ", _arr[i]);
            }

            Console.WriteLine();
        }

        //б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

        public MyArray(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] ss = File.ReadAllLines(fileName);
                _arr = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    _arr[i] = int.Parse(ss[i]);
                }
            }
            else
            {
                Console.WriteLine($"Ошибка, {fileName} не найден");
            }
        }

        public static void Reading(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] strArr = File.ReadAllLines(fileName);
                for (int i = 0; i < strArr.Length; i++)
                {
                    Console.Write(strArr[i] + " ");
                }
            }
            else
            {
                Console.WriteLine($"Ошибка, {fileName} не найден");
            }
        }

        public void Record(string fileName)
        {
            string[] aString = new string[_arr.Length];
            Random a = new Random();
            for (int i = 0; i < aString.Length; i++)
            {
                aString[i] = Convert.ToString(a.Next(50));
                File.WriteAllLines(fileName, aString);
            }
        }
    }
}