using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using WMPLib;
using TetrisLib;
using MySql.Data.MySqlClient;

namespace Tetris
{
    public partial class MainForm : Form
    {
        public Game game;
        public GroupBox gameField;
        public GroupBox showField;
        public GroupBox statisticField;
        public Panel[][] panelsGame;
        public Panel[][] panelsShow;
        public Panel[][] panelsStatistic;
        WindowsMediaPlayer backgroundMusic = new WindowsMediaPlayer();
        SoundPlayer sp = new SoundPlayer(Properties.Resources.zvuk_tetrisa_na_konsoli);

        public MainForm()
        {
            InitializeComponent();
            StartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            Size = new Size(1920, 1080);
            sp.PlayLooping();
        }

        public void StartGame()
        {
            game = new Game();
            FillPanelsArrs(ref panelsGame, game.gameField, (int)GameFieldParms.cellSide);
            FillPanelsArrs(ref panelsShow, game.showField, (int)ShowFieldParms.cellSide);
            FillPanelsArrs(ref panelsStatistic, game.statisticField, (int)StatisticFieldParms.cellSide);
            DrawField(ref gameField, game.gameField, (int)GameFieldParms.X, (int)GameFieldParms.Y, (int)GameFieldParms.cellSide, panelsGame);
            DrawField(ref showField, game.showField, (int)ShowFieldParms.X, (int)ShowFieldParms.Y, (int)ShowFieldParms.cellSide, panelsShow);
            DrawField(ref statisticField, game.statisticField, (int)StatisticFieldParms.X,
                (int)StatisticFieldParms.Y, (int)StatisticFieldParms.cellSide, panelsStatistic);

            DrawCells(game.statisticField, panelsStatistic);

            game.StartGame();
            SetTimerInterval();
            DesignPanels();
            MakePauseLabel();
            SetNicknameLable();
        }

        public Color GetColorFromRGB(byte[] numbers) => Color.FromArgb(numbers[0], numbers[1], numbers[2]);

        public void FillPanelsArrs(ref Panel[][] panels, Field field, int cellSize)
        {
            panels = new Panel[field.width][];
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i] = new Panel[field.height];
                for (int j = 0; j < panels[i].Length; j++)
                {
                    panels[i][j] = new Panel();
                    Panel p = panels[i][j];
                    p.BorderStyle = BorderStyle.FixedSingle;
                    p.Size = new Size(cellSize, cellSize);
                    p.BackColor = GetColorFromRGB(Game.transparentColor.GetRGBNumbers());
                    p.Location = new Point(0, 0);
                }
            }
        }

        public void DrawField(ref GroupBox Field, Field field, int x, int y, int sideLength, Panel[][] panels)
        {
            if (Field != null)
                Field.Dispose();

            Field = new GroupBox
            {
                Location = new Point(x, y),
                Size = new Size(field.width * sideLength, field.height * sideLength),
                BackColor = Color.LimeGreen
            };
            Controls.Add(Field);

            AddPanelsToGroupBox(Field, panels, sideLength);
        }

        public void AddPanelsToGroupBox(GroupBox Field, Panel[][] panels, int cellSize)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                for (int j = 0; j < panels[i].Length; j++)
                {
                    Field.Controls.Add(panels[i][j]);
                    panels[i][j].Location = new Point(i * cellSize, j * cellSize);
                    panels[i][j].BringToFront();
                }
            }
        }

        public void DrawCells(Field field, Panel[][] panels)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                for (int j = 0; j < panels[i].Length; j++)
                {
                    panels[i][j].BackColor = GetColorFromRGB(field.cells[i][j].color.GetRGBNumbers());

                    if (field is StatisticField)
                    {
                        if (field.cells[i][j].color == Game.transparentColor)
                            panels[i][j].BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        public void RenewStatistic()
        {
            label1.Text = string.Format("{0:00000000}", game.points);
            label4.Text = string.Format("{0:0000}", game.level.level);
            Label3.Text = "LINES - " + String.Format("{0:0000}", game.delLinesAm);
            label8.Text = string.Format("{0:00000}", FigureCaterparral_L.figAmmount);
            label9.Text = string.Format("{0:00000}", FigureCaterparral_R.figAmmount);
            label10.Text = string.Format("{0:00000}", FigureL.figAmmount);
            label11.Text = string.Format("{0:00000}", FigureLRevers.figAmmount);
            label12.Text = string.Format("{0:00000}", FigurePedustal.figAmmount);
            label13.Text = string.Format("{0:00000}", FigureSquare.figAmmount);
            label14.Text = string.Format("{0:00000}", FigureStick.figAmmount);
        }

        public void DesignPanels()
        {
            panel_statistic_1.SendToBack();
            panel_statistic_2.SendToBack();
            panel_statistic_3.SendToBack();
            panel_game_1.SendToBack();
            panel_show_1.SendToBack();
        }

        public void MakePauseLabel()
        {
            Controls.Add(Pause_label);
            Pause_label.AutoSize = true;
            Pause_label.Font = new Font("Verdana", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Pause_label.ForeColor = SystemColors.ControlDark;
            Pause_label.Location = new Point(540, 389);
            Pause_label.Name = "Pause_label";
            Pause_label.Size = new Size(507, 145);
            Pause_label.TabIndex = 0;
            Pause_label.Text = "PAUSE";
            Pause_label.BackColor = Color.White;
        }

        public void SetNicknameLable() => Nickname_label.Text = Program.nickName == "DEFAULT" ? "'Anonim'" : Program.nickName;

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (game.gameField.figure != null)
                DrawCells(game.gameField, panelsGame);

            DrawCells(game.showField, panelsShow);
            RenewStatistic();
            SetTimerInterval();
            CheckGameEnd();
        }

        public void CheckGameEnd()
        {
            if (Game.stepTimer.Enabled)
                return;

            StopGame();
        }

        public void PauseGame()
        {
            if (game == null)
                return;

            if (timer.Enabled)
            {
                timer.Stop();
                sp.Stop();
                Pause_label.BringToFront();
            }
            else
            {
                timer.Start();
                sp.Play();
                Pause_label.SendToBack();
            }

            game.PauseGame();
        }

        public void StopGame()
        {
            timer.Enabled = false;
            MessageBox.Show($"Game over\nYour score: {game.points}");
            WriteInDB();
            game.StopGame();
            game = null;
        }

        public void WriteInDB()
        {
            try
            {
                string connStr = "Server=YAROSLAV-PC\\SQLEXPRESS;Password=1234;User ID=sa;Initial Catalog=Tetris";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();

                string sql = "INSERT UserPoints(Nickname, Points) VALUES(" + Program.nickName + ", " + game.points + ")";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception) { }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (game != null)
                StopGame();
            else
                StartGame();
        }

        public void SetTimerInterval()
        {
            timer.Interval = game.level.GetTimerInterval() / 25;
            timer.Enabled = true;
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (game == null) 
                return;

            if (e.KeyChar == 'w' || e.KeyChar == 'W' || e.KeyChar == 'ц' || e.KeyChar == 'Ц')
            {
                game.gameField.MakeTurnFigure();
            }
            else if (e.KeyChar == 'd' || e.KeyChar == 'D' || e.KeyChar == 'в' || e.KeyChar == 'В')
            {
                game.gameField.MoveRightFigure();
            }
            else if (e.KeyChar == 'a' || e.KeyChar == 'A' || e.KeyChar == 'ф' || e.KeyChar == 'Ф')
            {
                game.gameField.MoveLeftFigure();
            }
            else if (e.KeyChar == 's' || e.KeyChar == 'S' || e.KeyChar == 'і' || e.KeyChar == 'І')
            {
                game.gameField.MoveDownFigure();
            }
            else if (e.KeyChar == 'q' || e.KeyChar == 'Q' || e.KeyChar == 'й' || e.KeyChar == 'Й')
                PauseGame();
        }

        private void button_Pause_Click(object sender, EventArgs e) => PauseGame();

        private void button_exit_Click(object sender, EventArgs e) => Close();

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled) 
                PauseGame();

            RecordsForm recordsForm = new RecordsForm();
            recordsForm.TopMost = true;
            recordsForm.ShowDialog();
            PauseGame();
        }

        private void ChangeLogin_button_Click(object sender, EventArgs e)
        {
            if (game != null) 
                StopGame();

            LogInForm log = new LogInForm();
            log.TopMost = true;
            log.ShowDialog();
            StartGame();
        }
    }
}
