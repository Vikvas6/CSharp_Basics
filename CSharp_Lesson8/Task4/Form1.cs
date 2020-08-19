using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        Dictionary database;
        Random rnd;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new Dictionary(sfd.FileName);
                database.Add("Initial", "Начальный");
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        private void openWord(int num)
        {
            try
            {
                tbWord.Text = database[num - 1].word;
                tbTs.Text = database[num - 1].translation;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"Нет слова с номером {num}");
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("База данных не создана");
                return;
            }
            openWord((int)nudNumber.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add(tbWord.Text, tbTs.Text);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null)
            {
                MessageBox.Show("Нельзя удалить последнее слово");
                return;
            }
            database.Delete((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            openWord((int)nudNumber.Value);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    database = new Dictionary(ofd.FileName);
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Файл слишком большой");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка десериализации файла");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("База данных не создана");
                return;
            }
            database[(int)nudNumber.Value - 1].word = tbWord.Text;
            database[(int)nudNumber.Value - 1].translation = tbTs.Text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Простой словарик анлийских слов с переводом и возможностью открыть случайное слово\n" +
                "Версия 0.0.1\n" +
                "Авторские права не защищены, делайте, что хотите\n" +
                "Витёк");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database.FileName = sfd.FileName;
                database.Save();
            }
        }

        private void btnRnd_Click(object sender, EventArgs e)
        {
            if (database != null) nudNumber.Value = rnd.Next(1, database.Count);
            else MessageBox.Show("База данных не создана");
        }
    }
}
