namespace Lesson_7_HW
{
    partial class Task1
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblStaticCommandsCnt = new System.Windows.Forms.Label();
            this.lblCommandsCnt = new System.Windows.Forms.Label();
            this.lblStaticCurrent = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblCurrentGame = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(161, 33);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(161, 62);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(161, 91);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(112, 43);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // lblStaticCommandsCnt
            // 
            this.lblStaticCommandsCnt.AutoSize = true;
            this.lblStaticCommandsCnt.Location = new System.Drawing.Point(12, 91);
            this.lblStaticCommandsCnt.Name = "lblStaticCommandsCnt";
            this.lblStaticCommandsCnt.Size = new System.Drawing.Size(92, 13);
            this.lblStaticCommandsCnt.TabIndex = 4;
            this.lblStaticCommandsCnt.Text = "Commands count:";
            // 
            // lblCommandsCnt
            // 
            this.lblCommandsCnt.AutoSize = true;
            this.lblCommandsCnt.Location = new System.Drawing.Point(112, 91);
            this.lblCommandsCnt.Name = "lblCommandsCnt";
            this.lblCommandsCnt.Size = new System.Drawing.Size(13, 13);
            this.lblCommandsCnt.TabIndex = 5;
            this.lblCommandsCnt.Text = "0";
            // 
            // lblStaticCurrent
            // 
            this.lblStaticCurrent.AutoSize = true;
            this.lblStaticCurrent.Location = new System.Drawing.Point(12, 43);
            this.lblStaticCurrent.Name = "lblStaticCurrent";
            this.lblStaticCurrent.Size = new System.Drawing.Size(82, 13);
            this.lblStaticCurrent.TabIndex = 6;
            this.lblStaticCurrent.Text = "Current number:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(161, 121);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblCurrentGame
            // 
            this.lblCurrentGame.AutoSize = true;
            this.lblCurrentGame.Location = new System.Drawing.Point(15, 13);
            this.lblCurrentGame.Name = "lblCurrentGame";
            this.lblCurrentGame.Size = new System.Drawing.Size(59, 13);
            this.lblCurrentGame.TabIndex = 10;
            this.lblCurrentGame.Text = "labelStatus";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cheat button (Cancel)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCurrentGame);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblStaticCurrent);
            this.Controls.Add(this.lblCommandsCnt);
            this.Controls.Add(this.lblStaticCommandsCnt);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblStaticCommandsCnt;
        private System.Windows.Forms.Label lblCommandsCnt;
        private System.Windows.Forms.Label lblStaticCurrent;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblCurrentGame;
        private System.Windows.Forms.Button btnCancel;
    }
}

