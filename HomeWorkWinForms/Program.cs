﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeWorkWinForms
{
    static class Program
    {
        public static void Main()
        {
            Form form = new Form();
            form.Text = "Событие Paint";
            // У формы есть событие Paint,
            // в System.Windows.Form описан делегат PaintEventHandler,
            // который описывает сигнатуру методов, которые можно подключать на событие
            //Создаем делегат и указываем, что он указывает на метод MyPaintHandler

            form.Paint += new PaintEventHandler(MyPaintHandler);
            Application.Run(form);
        }
        static void MyPaintHandler(object objSender, PaintEventArgs pea)
        {
            // Получаем ссылку на класс Graphics, в котором содержатся поля и методы для рисования на форме
            Graphics grfx = pea.Graphics;
            // Очищаем форму, закрашивая ее цветом
            grfx.Clear(Color.PaleGoldenrod);
            // Будем в заголовке окна менять время, чтобы лучше понять, когда же срабатывает это событие
            (objSender as Form).Text = DateTime.Now.ToLongTimeString();
            // А также посмотрим, что же вызывает это событие
            Console.WriteLine(objSender.ToString());
        }


    }
}