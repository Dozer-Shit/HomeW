using System;
using System.Reflection;

namespace ConsoleApplication2
{
    internal class Program
    {
        static void Main()
        {
            Type dateTimeProperties = typeof(DateTime);
            PropertyInfo[] propertyInfos = dateTimeProperties.GetProperties();

            foreach(PropertyInfo pi in propertyInfos)
            {
                Console.WriteLine($"{pi}");
                
            }
        }
    }
}