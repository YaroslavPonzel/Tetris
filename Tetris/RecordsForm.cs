using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Tetris
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = "Server=YAROSLAV-PC\\SQLEXPRESS;Password=1234;User ID=sa;Initial Catalog=Tetris";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = "SELECT  nickname, points FROM userpoints ORDER BY points DESC";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();

                label2.Text = "";
                label3.Text = "";
                int count = 0;
                while (reader.Read() && count < 10)
                {
                    label2.Text += reader[0].ToString() + "\n";
                    label3.Text += reader[1].ToString() + "\n";
                    count++;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                label2.Text = "Server error...";
                label3.Text = "";
            }

        }

        private void Close_button_Click(object sender, EventArgs e) => Close();
    }
}
