namespace Tetris
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_Start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button_Pause = new System.Windows.Forms.Button();
            this.panel_statistic_1 = new System.Windows.Forms.Panel();
            this.panel_statistic_2 = new System.Windows.Forms.Panel();
            this.panel_statistic_3 = new System.Windows.Forms.Panel();
            this.panel_game_1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_game_2 = new System.Windows.Forms.Panel();
            this.Pause_label = new System.Windows.Forms.Label();
            this.panel_show_1 = new System.Windows.Forms.Panel();
            this.panel_show_4 = new System.Windows.Forms.Panel();
            this.panel_show_3 = new System.Windows.Forms.Panel();
            this.panel_show_2 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangeLogin_button = new System.Windows.Forms.Button();
            this.Nickname_label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel_statistic_2.SuspendLayout();
            this.panel_game_1.SuspendLayout();
            this.panel_game_2.SuspendLayout();
            this.panel_show_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Start.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_Start.Location = new System.Drawing.Point(78, 43);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(241, 140);
            this.button_Start.TabIndex = 5;
            this.button_Start.Text = "START";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer
            // 
            this.timer.Interval = 122;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(1399, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(1450, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 69);
            this.label2.TabIndex = 5;
            this.label2.Text = "SCORE";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label3.Location = new System.Drawing.Point(729, 150);
            this.Label3.Margin = new System.Windows.Forms.Padding(0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(500, 61);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "LINES";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(1473, 882);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 65);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(1461, 812);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 60);
            this.label5.TabIndex = 8;
            this.label5.Text = "LEVEL";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(1473, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 62);
            this.label6.TabIndex = 9;
            this.label6.Text = "NEXT";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(149, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 64);
            this.label7.TabIndex = 10;
            this.label7.Text = "STATISTICS";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(352, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 74);
            this.label8.TabIndex = 11;
            this.label8.Text = "00000";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(352, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 74);
            this.label9.TabIndex = 12;
            this.label9.Text = "00000";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(352, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 74);
            this.label10.TabIndex = 13;
            this.label10.Text = "00000";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(352, 628);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 74);
            this.label11.TabIndex = 14;
            this.label11.Text = "00000";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(352, 701);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 74);
            this.label12.TabIndex = 15;
            this.label12.Text = "00000";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(352, 774);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 74);
            this.label13.TabIndex = 16;
            this.label13.Text = "00000";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(352, 847);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 74);
            this.label14.TabIndex = 17;
            this.label14.Text = "00000";
            // 
            // button_Pause
            // 
            this.button_Pause.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Pause.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Pause.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_Pause.Location = new System.Drawing.Point(371, 43);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(241, 140);
            this.button_Pause.TabIndex = 18;
            this.button_Pause.Text = "PAUSE";
            this.button_Pause.UseVisualStyleBackColor = false;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // panel_statistic_1
            // 
            this.panel_statistic_1.BackColor = System.Drawing.Color.White;
            this.panel_statistic_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_statistic_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_statistic_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_statistic_1.Location = new System.Drawing.Point(5, 127);
            this.panel_statistic_1.Name = "panel_statistic_1";
            this.panel_statistic_1.Size = new System.Drawing.Size(522, 581);
            this.panel_statistic_1.TabIndex = 19;
            // 
            // panel_statistic_2
            // 
            this.panel_statistic_2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_statistic_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_statistic_2.Controls.Add(this.panel_statistic_3);
            this.panel_statistic_2.Controls.Add(this.panel_statistic_1);
            this.panel_statistic_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_statistic_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_statistic_2.Location = new System.Drawing.Point(78, 247);
            this.panel_statistic_2.Name = "panel_statistic_2";
            this.panel_statistic_2.Size = new System.Drawing.Size(534, 714);
            this.panel_statistic_2.TabIndex = 20;
            // 
            // panel_statistic_3
            // 
            this.panel_statistic_3.BackColor = System.Drawing.Color.White;
            this.panel_statistic_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_statistic_3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_statistic_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_statistic_3.Location = new System.Drawing.Point(5, 4);
            this.panel_statistic_3.Name = "panel_statistic_3";
            this.panel_statistic_3.Size = new System.Drawing.Size(522, 118);
            this.panel_statistic_3.TabIndex = 20;
            // 
            // panel_game_1
            // 
            this.panel_game_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_game_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_game_1.Controls.Add(this.panel2);
            this.panel_game_1.Controls.Add(this.panel_game_2);
            this.panel_game_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_game_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_game_1.Location = new System.Drawing.Point(694, 122);
            this.panel_game_1.Name = "panel_game_1";
            this.panel_game_1.Size = new System.Drawing.Size(583, 840);
            this.panel_game_1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 120);
            this.panel2.TabIndex = 23;
            // 
            // panel_game_2
            // 
            this.panel_game_2.BackColor = System.Drawing.Color.White;
            this.panel_game_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_game_2.Controls.Add(this.Pause_label);
            this.panel_game_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_game_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_game_2.Location = new System.Drawing.Point(4, 129);
            this.panel_game_2.Name = "panel_game_2";
            this.panel_game_2.Size = new System.Drawing.Size(573, 705);
            this.panel_game_2.TabIndex = 22;
            // 
            // Pause_label
            // 
            this.Pause_label.AutoSize = true;
            this.Pause_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pause_label.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pause_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Pause_label.Location = new System.Drawing.Point(32, 239);
            this.Pause_label.Name = "Pause_label";
            this.Pause_label.Size = new System.Drawing.Size(509, 147);
            this.Pause_label.TabIndex = 0;
            this.Pause_label.Text = "PAUSE";
            // 
            // panel_show_1
            // 
            this.panel_show_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_show_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_show_1.Controls.Add(this.panel_show_4);
            this.panel_show_1.Controls.Add(this.panel_show_3);
            this.panel_show_1.Controls.Add(this.panel_show_2);
            this.panel_show_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_show_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_show_1.Location = new System.Drawing.Point(1362, 247);
            this.panel_show_1.Name = "panel_show_1";
            this.panel_show_1.Size = new System.Drawing.Size(394, 714);
            this.panel_show_1.TabIndex = 21;
            // 
            // panel_show_4
            // 
            this.panel_show_4.BackColor = System.Drawing.Color.White;
            this.panel_show_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_show_4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_show_4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_show_4.Location = new System.Drawing.Point(4, 4);
            this.panel_show_4.Name = "panel_show_4";
            this.panel_show_4.Size = new System.Drawing.Size(384, 172);
            this.panel_show_4.TabIndex = 24;
            // 
            // panel_show_3
            // 
            this.panel_show_3.BackColor = System.Drawing.Color.White;
            this.panel_show_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_show_3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_show_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_show_3.Location = new System.Drawing.Point(4, 180);
            this.panel_show_3.Name = "panel_show_3";
            this.panel_show_3.Size = new System.Drawing.Size(384, 366);
            this.panel_show_3.TabIndex = 23;
            // 
            // panel_show_2
            // 
            this.panel_show_2.BackColor = System.Drawing.Color.White;
            this.panel_show_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_show_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_show_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel_show_2.Location = new System.Drawing.Point(4, 550);
            this.panel_show_2.Name = "panel_show_2";
            this.panel_show_2.Size = new System.Drawing.Size(384, 158);
            this.panel_show_2.TabIndex = 22;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_exit.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.Color.IndianRed;
            this.button_exit.Location = new System.Drawing.Point(1589, 43);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(167, 140);
            this.button_exit.TabIndex = 22;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(1367, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "RECORDS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeLogin_button
            // 
            this.ChangeLogin_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeLogin_button.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLogin_button.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ChangeLogin_button.Location = new System.Drawing.Point(1367, 109);
            this.ChangeLogin_button.Name = "ChangeLogin_button";
            this.ChangeLogin_button.Size = new System.Drawing.Size(185, 77);
            this.ChangeLogin_button.TabIndex = 24;
            this.ChangeLogin_button.Text = "CHANGE NICKNAME";
            this.ChangeLogin_button.UseVisualStyleBackColor = false;
            this.ChangeLogin_button.Click += new System.EventHandler(this.ChangeLogin_button_Click);
            // 
            // Nickname_label
            // 
            this.Nickname_label.AutoSize = true;
            this.Nickname_label.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Nickname_label.Location = new System.Drawing.Point(707, 71);
            this.Nickname_label.Name = "Nickname_label";
            this.Nickname_label.Size = new System.Drawing.Size(0, 48);
            this.Nickname_label.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(724, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 48);
            this.label15.TabIndex = 26;
            this.label15.Text = "NOW PLAYS";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1921, 990);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Nickname_label);
            this.Controls.Add(this.ChangeLogin_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Pause);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.panel_show_1);
            this.Controls.Add(this.panel_game_1);
            this.Controls.Add(this.panel_statistic_2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Tetris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            this.panel_statistic_2.ResumeLayout(false);
            this.panel_game_1.ResumeLayout(false);
            this.panel_game_2.ResumeLayout(false);
            this.panel_game_2.PerformLayout();
            this.panel_show_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Panel panel_statistic_1;
        private System.Windows.Forms.Panel panel_statistic_2;
        private System.Windows.Forms.Panel panel_game_1;
        private System.Windows.Forms.Panel panel_game_2;
        private System.Windows.Forms.Panel panel_show_1;
        private System.Windows.Forms.Panel panel_show_2;
        private System.Windows.Forms.Panel panel_statistic_3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_show_3;
        private System.Windows.Forms.Panel panel_show_4;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label Pause_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ChangeLogin_button;
        private System.Windows.Forms.Label Nickname_label;
        private System.Windows.Forms.Label label15;
    }
}

