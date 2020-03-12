using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        private readonly Random _randBombPosition = new Random();
        private int _scoreBomb = 0;
        private int _fail = 3;
        private readonly Timer _timer = new Timer();
        private readonly Timer _timer2 = new Timer();

        public Form2()
        {
            InitializeComponent();
            
            Control cont = bomb;

            _timer.Interval = 50;
            _timer.Tick += delegate(object o, EventArgs args) { Timer_Tick(o, args, cont); };
            _timer.Enabled = true;

            _timer2.Interval = 3000;
            _timer2.Tick += delegate(object o, EventArgs args) { Timer_Tick2(o, args, out cont); };
            _timer2.Enabled = true;
        }


        private void Timer_Tick2(object sender, EventArgs e, out Control control)
        {
            control = new PictureBox
            {
                Location = new Point(_randBombPosition.Next(10, 750), -60),
                Image = Image.FromFile(@"C:\Users\Evgeny\Desktop\For_Game\bombo.png"),
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent
            };
            Controls.Add(control);
        }

        private void Timer_Tick(object sender, EventArgs e, Control control)
        {
            Point pointY = new Point(0, 10);
            control.Location += (Size) pointY;
            if (kim.Location.X <= control.Location.X && control.Location.X <= kim.Location.X + kim.Width &&
                control.Location.Y + control.Height >= kim.Location.Y)
            {
                _scoreBomb++;
                Controls.Remove(control);
                score.Text = $@"SCORE: {_scoreBomb}";
            }

            else if (control.Location.Y + control.Height > 440)
            {
                Controls.Remove(control);
                _fail--;
                life.Text = $@"LIFE: {_fail}";

                if (_fail < -20)
                {
                    _timer.Stop();
                    _timer2.Stop();

                    DialogResult result = MessageBox.Show(@"Чтобы выйти нажмите кнопку", @"Вы проиграли :(",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void kim_KeyDown(object sender, KeyEventArgs e)
        {
            Point pointX = new Point(10, 0);
            
            if (e.KeyCode == Keys.Left)
            {
                kim.Location -= (Size) pointX;
            }
            
            else if (e.KeyCode == Keys.Right)
            {
                kim.Location += (Size) pointX;
            }
        }
    }
}