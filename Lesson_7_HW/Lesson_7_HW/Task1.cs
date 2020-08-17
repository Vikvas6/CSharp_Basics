using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7_HW
{
    public partial class Task1 : Form
    {
        //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        //Игрок должен получить это число за минимальное количество ходов.
        //в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
        //Вся логика игры должна быть реализована в классе с удвоителем.
        //Вашченков Виктор

        static string START_GAME = "Start the game by press \"Play\" button";
        static string GAME_IN_PROGRESS = "Game is started! Reach the number: ";
        static bool IsGame = false;
        
        Random r;
        int TargetNumber;

        delegate string Cmd(string number);
        private string Cmd_Inc(string number)
        {
            return (int.Parse(number) + 1).ToString();
        }
        private string Cmd_Inc_Cancel(string number)
        {
            return (int.Parse(number) - 1).ToString();
        }
        private string Cmd_Dbl(string number)
        {
            return (int.Parse(number) * 2).ToString();
        }
        private string Cmd_Dbl_Cancel(string number)
        {
            return (int.Parse(number) / 2).ToString();
        }

        Dictionary<Cmd, Cmd> Cancel_CMD;
        Stack<Cmd> history;

        public Task1()
        {
            InitializeComponent();
            this.Text = "Удвоитель";
            lblCurrentGame.Text = START_GAME;
            r = new Random();

            Cancel_CMD = new Dictionary<Cmd, Cmd>();
            Cancel_CMD.Add(Cmd_Inc, Cmd_Inc_Cancel);
            Cancel_CMD.Add(Cmd_Dbl, Cmd_Dbl_Cancel);

            ResetStack();

            btnCancel.Enabled = false;
        }

        private void SaveCmdToStack(Cmd command)
        {
            history.Push(command);
            btnCancel.Enabled = true;
        }
        private Cmd GetFromStack()
        {
            if (history.Count == 1) btnCancel.Enabled = false;
            return history.Pop();
        }
        private void ResetStack()
        {
            history = new Stack<Cmd>();
            btnCancel.Enabled = false;
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = Cmd_Inc(lblNumber.Text);
            lblCommandsCnt.Text = Cmd_Inc(lblCommandsCnt.Text);
            SaveCmdToStack(Cmd_Inc);
            check_game();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = Cmd_Dbl(lblNumber.Text);
            lblCommandsCnt.Text = Cmd_Inc(lblCommandsCnt.Text);
            SaveCmdToStack(Cmd_Dbl);
            check_game();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset_numbers();
            stop_game();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            reset_numbers();
            IsGame = true;
            TargetNumber = r.Next(1, 100);
            lblCurrentGame.Text = GAME_IN_PROGRESS + TargetNumber.ToString();
        }

        private void stop_game()
        {
            IsGame = false;
            lblCurrentGame.Text = START_GAME;
        }
        private void reset_numbers()
        {
            lblNumber.Text = "0";
            lblCommandsCnt.Text = "0";
            ResetStack();
        }
        private void check_game()
        {
            if (IsGame)
            {
                if (int.Parse(lblNumber.Text) == TargetNumber)
                {
                    MessageBox.Show($"Congratulation! You used {lblCommandsCnt.Text} commands to reach target number. Your can continue or start a new game");
                    stop_game();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cmd Cancel_Action = GetFromStack();
            lblNumber.Text = Cancel_CMD[Cancel_Action](lblNumber.Text);
            lblCommandsCnt.Text = Cmd_Inc_Cancel(lblCommandsCnt.Text);
        }
    }
}
