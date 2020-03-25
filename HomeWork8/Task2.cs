using System;
using System.Windows.Forms;

//Задача 2
namespace HomeWork8
{
    public class Task2
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {
                textBox1.Text = numericUpDown1.Value.ToString();
            }
        }
    }
}