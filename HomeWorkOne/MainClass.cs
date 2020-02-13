using System;

namespace HomeWorkOne
{
    public class MainClass
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        public static int Rand()
        {
            Random ran = new Random();
            var randInt = ran.Next(0, 1000);
            return randInt;
        }
    }
}