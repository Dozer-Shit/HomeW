using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tableLayoutPanel1.Controls.Add(new Button());

            for (int i = 0; i < tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.Controls[i].Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls[i].Cursor = Cursors.Cross;
                tableLayoutPanel1.Controls[i].BackColor = Color.Brown;
                tableLayoutPanel1.Controls[i].Name = "button" + $"{i}";
                tableLayoutPanel1.Controls[i].Click += button_Click;
                tableLayoutPanel1.Controls.Add(new Button());
            }

//            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.Controls[16]);

//            Random rndButton = new Random();
//            for (int i = 0; i < 4; i++)
//            {
//                var elem = tableLayoutPanel1.Controls[rndButton.Next(15)];
//                elem.BackColor = Color.Coral;
//            }

            tableLayoutPanel1.Controls[0].BackColor = Color.Coral;
            tableLayoutPanel1.Controls[3].BackColor = Color.Coral;
            tableLayoutPanel1.Controls[5].BackColor = Color.Coral;
            tableLayoutPanel1.Controls[6].BackColor = Color.Coral;
            tableLayoutPanel1.Controls[9].BackColor = Color.Coral;
            tableLayoutPanel1.Controls[10].BackColor = Color.Coral;
            tableLayoutPanel1.Controls[12].BackColor = Color.Coral;
            tableLayoutPanel1.Controls[15].BackColor = Color.Coral;

            MessageBox.Show(@"Сделайте все прямоугольки одним цветом", @"Правила победы", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Point pointX = new Point(194, 0);
            Point pointY = new Point(0, 100);

            Control locatioPlusX = tableLayoutPanel1.GetChildAtPoint(((Button) sender).Location + (Size) pointX);
            Control locatioMinusX = tableLayoutPanel1.GetChildAtPoint(((Button) sender).Location - (Size) pointX);
            Control locatioPlusY = tableLayoutPanel1.GetChildAtPoint(((Button) sender).Location + (Size) pointY);
            Control locatioMinusY = tableLayoutPanel1.GetChildAtPoint(((Button) sender).Location - (Size) pointY);

            if (((Button) sender).BackColor == Color.Brown)
            {
                Logic(sender, locatioPlusX, locatioMinusX, locatioPlusY, locatioMinusY, Color.Coral);
            }
            else if (((Button) sender).BackColor == Color.Coral)
            {
                Logic(sender, locatioPlusX, locatioMinusX, locatioPlusY, locatioMinusY, Color.Brown);
            }

            int coutBr = 0;
            int coutCor = 0;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i].BackColor == Color.Brown)
                {
                    coutBr++;
                }

                else if (tableLayoutPanel1.Controls[i].BackColor == Color.Coral)
                {
                    coutCor++;
                }
            }

            if (coutBr == tableLayoutPanel1.Controls.Count - 1 || coutCor == tableLayoutPanel1.Controls.Count - 1)
            {
                BackColor = Color.Lime;
                DialogResult result = MessageBox.Show(@"Запустить следующую игру", @"Победа !", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void Logic(object sender, Control locatioPlusX, Control locatioMinusX, Control locatioPlusY,
            Control locatioMinusY, Color color)
        {
            ((Button) sender).BackColor = color;
            if (locatioPlusX != null && locatioPlusX.BackColor == Color.Coral)
            {
                locatioPlusX.BackColor = Color.Brown;
            }

            else if (locatioPlusX != null && locatioPlusX.BackColor == Color.Brown)
            {
                locatioPlusX.BackColor = Color.Coral;
            }

            if (locatioMinusX != null && locatioMinusX.BackColor == Color.Brown)
            {
                locatioMinusX.BackColor = Color.Coral;
            }

            else if (locatioMinusX != null && locatioMinusX.BackColor == Color.Coral)
            {
                locatioMinusX.BackColor = Color.Brown;
            }

            if (locatioPlusY != null && locatioPlusY.BackColor == Color.Coral)
            {
                locatioPlusY.BackColor = Color.Brown;
            }

            else if (locatioPlusY != null && locatioPlusY.BackColor == Color.Brown)
            {
                locatioPlusY.BackColor = Color.Coral;
            }

            if (locatioMinusY != null && locatioMinusY.BackColor == Color.Brown)
            {
                locatioMinusY.BackColor = Color.Coral;
            }

            else if (locatioMinusY != null && locatioMinusY.BackColor == Color.Coral)
            {
                locatioMinusY.BackColor = Color.Brown;
            }
        }
    }
}