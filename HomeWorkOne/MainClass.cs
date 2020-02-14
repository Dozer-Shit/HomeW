using System;

namespace HomeWorkOne
{
    public class MainClass
    {
        public static void Pause()
        {
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        public static int Rand()
        {
            Random ran = new Random();
            var randInt = ran.Next(0, 100);
            return randInt;
        }
    }
}