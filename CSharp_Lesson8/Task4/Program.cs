﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    static class Program
    {
        // *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных
        // (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
        // Вашченков Виктор
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
