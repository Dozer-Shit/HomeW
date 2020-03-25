using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHW7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<PictureBox> imgBoxes = new List<PictureBox>();
            for (var index = 0; index < Controls.Count; index++)
            {
                var i = (PictureBox) Controls[index];
                int c = index;
                if (i.GetType() == typeof(PictureBox))
                {
                    imgBoxes.Add(i);
                    imgBoxes[c].BackColor = Color.Black;
                }
            }

            Random rndPicBox = new Random();
            for (int i = 0; i < 4; i++)
            {
                imgBoxes[rndPicBox.Next(63)].BackColor = Color.Coral;
            }
        }

        private void image1_Click(object sender, EventArgs e)
        {
            if (image1.BackColor == Color.Black)
            {
                image1.BackColor = Color.Coral;
            }
            else if (image1.BackColor == Color.Coral)
            {
                image1.BackColor = Color.Black;
            }
        }
    }
}