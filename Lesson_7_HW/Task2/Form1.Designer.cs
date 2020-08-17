namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGameMessage = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.lblStaticGuess = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnGuessForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameMessage
            // 
            this.lblGameMessage.AutoSize = true;
            this.lblGameMessage.Location = new System.Drawing.Point(30, 33);
            this.lblGameMessage.Name = "lblGameMessage";
            this.lblGameMessage.Size = new System.Drawing.Size(35, 13);
            this.lblGameMessage.TabIndex = 0;
            this.lblGameMessage.Text = "label1";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(156, 65);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 20);
            this.tbGuess.TabIndex = 1;
            // 
            // lblStaticGuess
            // 
            this.lblStaticGuess.AutoSize = true;
            this.lblStaticGuess.Location = new System.Drawing.Point(30, 65);
            this.lblStaticGuess.Name = "lblStaticGuess";
            this.lblStaticGuess.Size = new System.Drawing.Size(120, 13);
            this.lblStaticGuess.TabIndex = 2;
            this.lblStaticGuess.Text = "Ваше предположение:";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(262, 65);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(105, 23);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Мне повезёт!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnGuessForm
            // 
            this.btnGuessForm.Location = new System.Drawing.Point(374, 65);
            this.btnGuessForm.Name = "btnGuessForm";
            this.btnGuessForm.Size = new System.Drawing.Size(122, 23);
            this.btnGuessForm.TabIndex = 4;
            this.btnGuessForm.Text = "Мне нужна форма!";
            this.btnGuessForm.UseVisualStyleBackColor = true;
            this.btnGuessForm.Click += new System.EventHandler(this.btnGuessForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 112);
            this.Controls.Add(this.btnGuessForm);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblStaticGuess);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.lblGameMessage);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameMessage;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Label lblStaticGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnGuessForm;
    }
}

