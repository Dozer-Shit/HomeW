using System;
using System.IO;
using System.Text.RegularExpressions;


namespace HomeWork5
{
    struct Account
    {
        private string _login;
        private string _password;
        public string Password { get; private set; }

        public string Login
        {
            get { return _login; }
            private set
            {
                _login = value;

                // Regex
                string regMask = @"^[a-zA-Z][a-zA-Z0-9]{2,10}$";
                Regex regex = new Regex(regMask);
                if (!regex.IsMatch(_login))
                {
                    Console.WriteLine("Логин не соответствует формату");
                    _login = null;
                    return;
                }

                // Не Regex
                if (_login.Length < 2 || _login.Length > 10)
                {
                    Console.WriteLine("Логин должен быть больше 2 и не более 10 знаков");
                    _login = null;
                    return;
                }

                if (char.IsNumber(_login[0]))
                {
                    Console.WriteLine("Логин не может начинаться с цифры");
                    _login = null;
                    return;
                }

                for (int i = 0; i < _login.Length; i++)
                {
                    if (!Char.IsLetterOrDigit(_login[i]))
                    {
                        Console.WriteLine("Логин может содержать только буквы и цифры");
                        _login = null;
                        break;
                    }
                }
            }
        }

        public Account(string login, string password)
        {
            _login = login;
            _password = password;
            Password = _password;
            Login = _login;
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