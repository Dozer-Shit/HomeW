using System;

// Сделано

namespace HomeWork4
{
    internal static class Program
    {
        private static int[] RandArray()
        {
            Random ran = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(-10000, 10000);
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

        public static void Main()
        {
            // Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            // Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
            // В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

            Console.WriteLine("Демонстрация подсчета пар чисел");
            var a = RandArray();
            int b = Pair(a);
            Console.WriteLine($"Пар элементов массива делящихся на 3: {b}");

            // Дописать класс для работы с одномерным массивом.
            // Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
            // Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива,
            // метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
            // В Main продемонстрировать работу класса.
            Console.WriteLine("\nДемонстрация работы с одномерным массивом");

            MyArray arr = new MyArray(15, 0, 2);
            arr.Print();

            Console.WriteLine("Сумма: " + arr.Sum);

            arr.Inverse();
            Console.Write("Инверсия: ");
            arr.Print();

            arr.Multi(5);
            Console.Write("Умножаем на 5: ");
            arr.Print();

            Console.WriteLine("Количество максимальных элементов в массиве : " + arr.MaxCount);

            MyArray arrFile = new MyArray("test.txt");
            Console.WriteLine("Тестим чтение из файла");
            arrFile.Print();
            Console.WriteLine("Тестим запись в файл массива и чтение файла с обновленными данными");
            arrFile.Record("test.txt");
            MyArray.Reading("test.txt");

            // Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.

//            Console.WriteLine("\nПрограмма эмуляции авторизации.\n\nУстановите ваш логин и затем пароль");
//            Account setAcc = new Account(Console.ReadLine(), Console.ReadLine());
//            string[] arrBase = {setAcc.Login, setAcc.Password};
//            Account.RecFile(arrBase, "Data.txt");
//            Console.WriteLine(
//                "Отлично ! Ваши данные сохранены\nТеперь вам необходимо авторизоваться\nВведите ваши логин и пароль");
//
//            bool flag;
//            int count = 3;
//            do
//            {
//                if (count == 0)
//                {
//                    Console.WriteLine("Вы 3 раза ввели неправильный логин или пароль. Обратитесь в службу поддержки");
//                    break;
//                }
//
//                Console.WriteLine($"У вас есть {count} попыток для ввода данных");
//                Account getAcc = new Account(Console.ReadLine(), Console.ReadLine());
//                string[] answer = {getAcc.Login, getAcc.Password};
//                flag = Account.CheckAcc(answer, "Data.txt");
//                count--;
//            } while (!flag);

            //Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами.
            //Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,
            //свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива,
            //метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)

            Console.WriteLine("\nДемонстрация двумерного массива");
            RankArray array = new RankArray(3, 5);
            RankArray.RankSum(array.ArrRank);
            RankArray.RankSumMoreThan(array.ArrRank, 50);
            Console.WriteLine($"\nМинимальное число в массиве {array.MinElem}");
            Console.WriteLine($"Минимальное число в массиве {array.MaxElem}");
            int[] MaxNum;
            RankArray.MaxNum(array.ArrRank, out MaxNum);
            Console.WriteLine($"{MaxNum[0]} {MaxNum[1]}");
        }
    }
}