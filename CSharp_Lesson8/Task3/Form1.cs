using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        private void openQueston(int num)
        {
            try
            {
                tboxQuestion.Text = database[num - 1].text;
                cboxTrue.Checked = database[num - 1].trueFalse;
            } catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"Нет вопроса с номером {num}");
            }
        }
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("База данных не создана");
                return;
            }
            openQueston((int)nudNumber.Value);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null)
            {
                MessageBox.Show("Нельзя удалить последний вопрос");
                return;
            }
            database.Remove((int)nudNumber.Value-1);
            nudNumber.Maximum--;
            openQueston((int)nudNumber.Value);
        }
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }
        private void miOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    database = new TrueFalse(ofd.FileName);
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
            } catch (OutOfMemoryException)
            {
                MessageBox.Show("Файл слишком большой");
            } catch (Exception)
            {
                MessageBox.Show("Ошибка десериализации файла");
            }
        }
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("База данных не создана");
                return;
            }
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Верю-не верю\n" +
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
    }
}
