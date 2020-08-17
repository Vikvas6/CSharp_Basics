using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        //Используя Windows Forms, разработать игру «Угадай число».
        //Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
        //Компьютер говорит, больше или меньше загаданное число введенного.  
        //a) Для ввода данных от человека используется элемент TextBox;
        //б) **Реализовать отдельную форму c TextBox для ввода числа.
        //Вашченков Виктор
        
        Random r;
        string START_MESSAGE = "Компьютер загадал число (от 1 до 100), попробуйте угадать, какое!";
        string TOO_LOW_MESSAGE = "Компьютер загадал число больше #num, попробуйте ещё раз!";
        string TOO_HI_MESSAGE = "Компьютер загадал число меньше #num, попробуйте ещё раз!";
        string WIN_MESSAGE = "Поздравляю, небольшое число попыток (#tries) и Вы угадали число (#num)! Попробовать ещё раз?";
        int ComputerNumber;
        int Tries;
        bool InGame;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            StartNewGame();
        }
        private void StartNewGame()
        {
            ComputerNumber = r.Next(1, 100);
            lblGameMessage.Text = START_MESSAGE;
            InGame = true;
            Tries = 0;
            btnGuess.Text = "Мне повезёт!";
            btnGuessForm.Text = "Мне нужна форма!";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (InGame)
            {
                int UserNumber = int.Parse(tbGuess.Text);
                GameStep(UserNumber);    
            } else
            {
                StartNewGame();
            }
        }

        private void GameStep(int UserNumber)
        {
            if (UserNumber < ComputerNumber)
            {
                lblGameMessage.Text = TOO_LOW_MESSAGE.Replace("#num", UserNumber.ToString());
                Tries++;
            }
            else if (UserNumber > ComputerNumber)
            {
                lblGameMessage.Text = TOO_HI_MESSAGE.Replace("#num", UserNumber.ToString());
                Tries++;
            } else
            {
                lblGameMessage.Text = WIN_MESSAGE.Replace("#num", UserNumber.ToString()).Replace("#tries", Tries.ToString());
                InGame = false;
                btnGuess.Text = "Новая игра";
                btnGuessForm.Text = "Новая игра";
            }
        }

        private void btnGuessForm_Click(object sender, EventArgs e)
        {
            if (InGame)
            {
                Form2 fm = new Form2();
                fm.ShowDialog();
                GameStep(int.Parse(fm.Input));
            } else
            {
                StartNewGame();
            }
        }
    }
}
