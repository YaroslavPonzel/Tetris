using System;
using System.Windows.Forms;

namespace Tetris
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if(Nickname_textBox.Text == "")
                Program.nickName = "DEFAULT";
            else
                Program.nickName = "'" + Nickname_textBox.Text + "'";

            Close();
        }

        private void Anonymous_button_Click(object sender, EventArgs e)
        {
            Program.nickName = "DEFAULT";
            Close();
        }
    }
}

