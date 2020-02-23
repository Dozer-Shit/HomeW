using System;

namespace HomeWork3
{
    // Описание класса дробей с исключением в Denominator set
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator { get; set; }

        public int Denominator
        {
            get { return _denominator; }
            private set
            {
                if (_denominator == 0)
                {
                    throw new ArgumentException("Знаменатель не может = 0");
                }

                if (_denominator != 0)
                {
                    _denominator = value;
                }
            }
        }

        // Пустой конструктор (просто чтоб был для инициализации перед try)
        public Fraction()
        {
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
            Numerator = _numerator;
            Denominator = _denominator;
        }

        // Метод сложения
        public static Fraction Addition(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(
                fractionA.Numerator * fractionB.Denominator + fractionB.Numerator * fractionA.Denominator,
                fractionA.Denominator * fractionB.Denominator);
        }

        // Метод вычитания
        public static Fraction Subtraction(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(
                fractionA.Numerator * fractionB.Denominator - fractionB.Numerator * fractionA.Denominator,
                fractionA.Denominator * fractionB.Denominator
            );
        }

        // Метод умножения
        public static Fraction Multiplication(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(fractionA.Numerator * fractionB.Numerator,
                fractionA.Denominator * fractionB.Denominator);
        }

        // Метод деления
        public static Fraction Division(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(fractionA.Numerator * fractionB.Denominator,
                fractionB.Numerator * fractionA.Denominator);
        }

        // Сокращаем дроби
        public static Fraction Reduction(Fraction fraction)
        {
            double min = Math.Abs(Math.Min(fraction.Denominator, fraction.Numerator));
            for (double i = min; i >= 2; i--)
            {
                if (fraction.Numerator % i == 0 && fraction.Denominator % i == 0)
                {
                    fraction.Numerator = (int) (fraction.Numerator / i);
                    fraction.Denominator = (int) (fraction.Denominator / i);
                }
            }

            // Перенос знака из знаменателя в числитель
            if (fraction.Denominator < 0)
            {
                fraction.Numerator = -1 * fraction.Numerator;
                fraction.Denominator = Math.Abs(fraction.Denominator);
            }

            return fraction;
        }

        // Выводим целую часть из неправильной дроби (лень было переписывать метод сокращения и сделал отдельным :))
        public static (int, Fraction) IntPart(Fraction fraction)
        {
            (int, Fraction) resulte = (default, fraction);
            if (fraction.Numerator > fraction.Denominator)
            {
                int intPart = fraction.Numerator / fraction.Denominator;
                fraction.Numerator -= fraction.Denominator;
                resulte = (intPart, fraction);
            }

            return resulte;
        }
    }
}