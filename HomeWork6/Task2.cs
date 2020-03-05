using System.Collections.Generic;
using System.IO;

namespace HomeWork6
{
    public class Task2
    {
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x * x;
        }

        public static void SaveFunc(string fileName, double startPoint, double endPoint, double step, Fun2 f)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = startPoint;
            while (x <= endPoint)
            {
                bw.Write(f(x));
                x += step;
            }

            bw.Close();
            fs.Close();
        }


        public static List<double> Load(string fileName, ref double minimum)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            List<double> mass = new List<double>();
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                mass.Add(d);
                if (d < min)
                {
                    min = d;
                }
            }

            minimum = min;

            bw.Close();
            fs.Close();
            return mass;
        }
    }
}