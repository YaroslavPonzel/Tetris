namespace Tetris
{
    partial class LogInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nickname_textBox = new System.Windows.Forms.TextBox();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Anonymous_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR NICKNAME";
            // 
            // Nickname_textBox
            // 
            this.Nickname_textBox.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname_textBox.Location = new System.Drawing.Point(21, 132);
            this.Nickname_textBox.Name = "Nickname_textBox";
            this.Nickname_textBox.Size = new System.Drawing.Size(423, 40);
            this.Nickname_textBox.TabIndex = 1;
            // 
            // Accept_button
            // 
            this.Accept_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Accept_button.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept_button.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Accept_button.Location = new System.Drawing.Point(21, 193);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(423, 57);
            this.Accept_button.TabIndex = 2;
            this.Accept_button.Text = "ACCEPT";
            this.Accept_button.UseVisualStyleBackColor = false;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Anonymous_button
            // 
            this.Anonymous_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Anonymous_button.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Anonymous_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Anonymous_button.Location = new System.Drawing.Point(21, 295);
            this.Anonymous_button.Name = "Anonymous_button";
            this.Anonymous_button.Size = new System.Drawing.Size(423, 44);
            this.Anonymous_button.TabIndex = 3;
            this.Anonymous_button.Text = "ANONYMOUS PLAYER";
            this.Anonymous_button.UseVisualStyleBackColor = false;
            this.Anonymous_button.Click += new System.EventHandler(this.Anonymous_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(465, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 418);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 418);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 418);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 10);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Location = new System.Drawing.Point(0, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(473, 10);
            this.panel5.TabIndex = 7;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(472, 383);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Anonymous_button);
            this.Controls.Add(this.Accept_button);
            this.Controls.Add(this.Nickname_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nickname_textBox;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Button Anonymous_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}