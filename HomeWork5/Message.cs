using System;
using System.Collections;
using System.IO;
using System.Text;

namespace HomeWork5
{
    //Разработать класс Message, содержащий следующие статические методы для обработки
    //текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //Продемонстрируйте работу программы на текстовом файле с вашей программой.

    public class Message
    {
        public static string[] SplitStr(string text)
        {
            string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < words.Length; i++)
            {
                string word = words[i];
                Console.WriteLine(word);
            }

            return words;
        }

        public static void CharLength(string[] text, int range)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length < range)
                {
                    Console.WriteLine(text[i]);
                }
            }
        }

        public static void DelWords(string[] text, string symbol)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].EndsWith(symbol))
                {
                    text[i] = text[i].Remove(0, text[i].Length);
                }
            }

            string fullStr = string.Join(" ", text);
            fullStr = string.Join(" ", fullStr.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));
            Console.Write($"{fullStr} ");
        }

        public static ArrayList MaxWordLength(string[] text)
        {
            string max = text[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > max.Length)
                {
                    max = text[i];
                }
            }

            ArrayList maxWords = new ArrayList();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length == max.Length)
                {
                    maxWords.Add(text[i]);
                    Console.WriteLine(text[i]);
                }
            }

            return maxWords;
        }

        public static void JoinStroke(ArrayList text, string file)
        {
            StringBuilder sb = new StringBuilder(100);
            for (int i = 0; i < text.Count; i++)
            {
                sb.Append(text[i] + " ");
            }

            string[] fileL = {sb.ToString()};
            File.WriteAllLines(file, fileL);
        }
    }
}