namespace Task2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStaticGuess = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStaticGuess
            // 
            this.lblStaticGuess.AutoSize = true;
            this.lblStaticGuess.Location = new System.Drawing.Point(12, 9);
            this.lblStaticGuess.Name = "lblStaticGuess";
            this.lblStaticGuess.Size = new System.Drawing.Size(120, 13);
            this.lblStaticGuess.TabIndex = 3;
            this.lblStaticGuess.Text = "Ваше предположение:";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(138, 9);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 20);
            this.tbGuess.TabIndex = 4;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(244, 9);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(105, 23);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Мне повезёт!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 40);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.lblStaticGuess);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaticGuess;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Button btnGuess;
    }
}