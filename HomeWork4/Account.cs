using System;
using System.IO;

// Сделано

namespace HomeWork4
{
    struct Account
    {
        public string Password { get; set; }
        public string Login { get; set; }

        public Account(string password, string login)
        {
            Password = password;
            Login = login;
        }

        public static void RecFile(string[] arr, string fileName)
        {
            string[] dataUser = arr;
            for (int i = 0; i < fileName.Length; i++)
            {
                File.WriteAllLines(fileName, dataUser);
            }
        }

        public static bool CheckAcc(string[] arrUser, string fileName)
        {
            string[] fileArr = File.ReadAllLines(fileName);

            for (int i = 0; i < arrUser.Length; i++)
            {
                if (!arrUser[i].Equals(fileArr[i]))
                {
                    Console.WriteLine("Вы ввели неправильно пароль или логин, поробуйте повторить попытку");
                    return false;
                }
            }

            Console.WriteLine("Авторизация пройдена успешно");
            return true;
        }
    }
}