using System;
using System.Reflection;

//Задача 1
namespace HomeWork8
{
    public class Task1
    {
        static void Main1()
        {
            Type timeProperties = typeof(DateTime);
            PropertyInfo[] propertyInfos = timeProperties.GetProperties();

            for (var i = 0; i < propertyInfos.Length; i++)
            {
                PropertyInfo pInfo = propertyInfos[i];
                Console.WriteLine($"{pInfo}");
            }
        }
    }
}