using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "\nПрограмма эмуляции авторизации.\n\nУстановите ваш логин и затем пароль\nДопустимая длина логина от 2 до 10 знаков" +
                "из цифр и букв латинского алфавита и не должен начинаться на цифру\n");
            Account setAcc;
            do
            {
                setAcc = new Account(Console.ReadLine(), Console.ReadLine());
            } while (setAcc.Login == null);

            string[] arrBase = {setAcc.Login, setAcc.Password};
            Account.RecFile(arrBase, "Data.txt");
            Console.WriteLine(
                "Отлично ! Ваши данные сохранены\nТеперь вам необходимо авторизоваться\nВведите ваши логин и пароль");

            bool flag;
            int count = 3;
            do
            {
                if (count == 0)
                {
                    Console.WriteLine("Вы 3 раза ввели неправильный логин или пароль. Обратитесь в службу поддержки");
                    break;
                }

                Console.WriteLine($"У вас есть {count} попыток для ввода данных");
                Account getAcc = new Account(Console.ReadLine(), Console.ReadLine());
                string[] answer = {getAcc.Login, getAcc.Password};
                flag = Account.CheckAcc(answer, "Data.txt");
                count--;
            } while (!flag);
            string[] strArr = Message.SplitStr("Вот такой вот незамысловатый текст подается незамысловат20");
            Console.WriteLine("Слова не более N");
            Message.CharLength(strArr, 6);
            Console.WriteLine("Слова не оканчивающиеся на Т");
            Message.DelWords(strArr, "т");
            Console.WriteLine("\nСамые длинные слова");
            ArrayList maxLength = Message.MaxWordLength(strArr);
            Message.JoinStroke(maxLength, "LengthFile.txt");

            //Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
            //а) с использованием методов C#;
            //б) *разработав собственный алгоритм.

            string a = Console.ReadLine().ToLower();
            string b = Console.ReadLine().ToLower();
            Palindrome(a, b);
            Pal("андив апож ад асарк алам", "мала краса да жопа видна");
        }

        private static void Palindrome(string text1, string text2)
        {
            char[] arrStr = text1.ToCharArray();
            Array.Reverse(arrStr);
            string output = new string(arrStr);

            if (output.Equals(text2))
            {
                Console.WriteLine("Является перестановкой");
            }
        }

        private static void Pal(string text1, string text2)
        {
            int b = text2.Length - 1;
            if (text1.Length != text2.Length)
            {
                Console.WriteLine("Длины строк не сходятся, они не могут быть перестановкой");
                return;
            }

            for (int i = 0; i < text1.Length; i++, b--)
            {
                char f = text1[i];
                char c = text2[b];
                if (f == c)
                {
                    Console.WriteLine(
                        $"Начальный символ первой строки {f} cходится с конечным символом {c} второй строки");
                }
                else if (f != c)
                {
                    Console.WriteLine("Строки не могут являться перестановкой");
                    break;
                }
            }

            Console.WriteLine($"{text1} и {text2} являются перестановкой");

            //Задача ЕГЭ.

            Console.WriteLine("Задача по ЕГЭ");
            Console.WriteLine("Введите кол-во учеников");
            int numStud = 0;
            do
            {
                numStud = Convert.ToInt32(Console.ReadLine());
            } while (numStud < 10 || numStud > 100);

            Console.WriteLine(
                "Введите фамилию, имя и 3 оценки по 5 бальной шкалле\nПример: Петров Петр 3 5 4\nДля остановки вода введите stop");
            string studData = "";
            ArrayList arrStudData = new ArrayList();
            Regex mask = new Regex(@"^[A-ZА-Я][a-zа-я]{1,20}\s[A-ZА-Я][a-zа-я]{1,15}(\s[1-5]){3}$");
            do
            {
                studData = Console.ReadLine();
                if (studData != null && studData.Equals("stop"))
                {
                    Console.WriteLine("Ввод данных закончен");
                    break;
                }

                if (!mask.IsMatch(studData))
                {
                    Console.WriteLine("Ваша форма записи некорректна");
                }
                else if (mask.IsMatch(studData))
                {
                    arrStudData.Add(studData);
                }
            } while (arrStudData.Count != numStud);

            for (int i = 0; i < arrStudData.Count; i++)
            {
                
            }
        }
    }
}