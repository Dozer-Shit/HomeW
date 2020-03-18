using System;
using System.IO;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class Form1 : Form
    {
        private const int Mbyte = 8388608;

        private TrueFalse _database;

        public Form1()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(saveFile.FileName);
                _database.Add("Текст вопроса", true);
                _database.Save();
                counter.Minimum = 1;
                counter.Maximum = 1;
                counter.Value = 1;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var openedFile = new FileInfo(openFile.FileName);
                if (openedFile.Length > Mbyte)
                {
                    MessageBox.Show(@"Слишком большой файл");
                    return;
                }

                if (Path.GetExtension(openFile.FileName) != ".dat")
                {
                    MessageBox.Show(@"Файл должен иметь расширение .dat");
                    return;
                }

                try
                {
                    _database = new TrueFalse(openFile.FileName);
                    _database.Load();
                    counter.Minimum = 1;
                    counter.Maximum = _database.Count;
                    counter.Value = 1;
                }
                catch (Exception exc)
                {
                    MessageBox.Show($@"Нельзя открыть пустую базу!\n\n {exc.Message}", @"Ошибка открытия файла");
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (_database != null) _database.Save();
            else MessageBox.Show(@"База данных отсутствует");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (_database == null)
            {
                MessageBox.Show(@"Создайте новую базу данных", @"Инфо");
                return;
            }

            _database.Add((_database.Count + 1).ToString(), true);
            counter.Maximum = _database.Count;
            counter.Value = _database.Count;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (counter.Maximum == 1 || counter.Maximum == 0 || _database == null) return;
            _database.Remove((int) counter.Value);
            counter.Maximum--;
            if (counter.Value > 1) counter.Value = counter.Value;
        }

        private void butSaveQuest_Click(object sender, EventArgs e)
        {
            if (_database == null)
            {
                MessageBox.Show(@"Отсутствует база данных", @"Ошибка сохранения");
                return;
            }

            _database[(int) counter.Value - 1].Text = tboxQuestion.Text;
            _database[(int) counter.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void counter_ValueChanged(object sender, EventArgs e)
        {
            if (_database == null || counter.Value > _database.Count || counter.Value < 1) return;

            tboxQuestion.Text = _database[(int) counter.Value - 1].Text;
            cboxTrue.Checked = _database[(int) counter.Value - 1].TrueFalse;
        }

        private void ProgAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Название: Верю - Не верю Database
            Автор:       Dozer", @"О программе");
        }

        private void butSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(_database.Count.ToString());
                _database.SaveAs(sfd.FileName);
            }
        }
    }
}