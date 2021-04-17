using System;
using System.Collections.Generic;

namespace TetrisLib
{
    public class Game
    {
        private List<Type> figureTypes = new List<Type>
        {
            typeof(FigureSquare), typeof(FigureLRevers), typeof(FigurePedustal), typeof(FigureL),
            typeof(FigureStick), typeof(FigureCaterparral_L), typeof(FigureCaterparral_R)
        };

        public static readonly RGBColor transparentColor = new RGBColor(255, 255, 255);
        public static System.Timers.Timer stepTimer;
        public Level level { get; set; }
        public GameField gameField { get; set; }
        public ShowNextField showField { get; set; }
        public StatisticField statisticField { get; set; }
        public int points { get; private set; }
        public int delLinesAm { get; private set; }
        public Figure CurrentFigure { get; private set; }
        public Figure NextFigure { get; private set; }

        public Game()
        {
            level = new Level();
            gameField = new GameField();
            showField = new ShowNextField();
            statisticField = new StatisticField();
            CurrentFigure = GetRandomFigure();
            System.Threading.Thread.Sleep(50);
            NextFigure = GetRandomFigure();
            gameField.AddFigure(CurrentFigure);
            showField.AddFigure(NextFigure);
            gameField.RenewInf();
            showField.RedrawField();

            points = 0;
            delLinesAm = 0;
        }

        public void StartGame()
        {
            FigureCaterparral_L.figAmmount = 0;
            FigureCaterparral_R.figAmmount = 0;
            FigureL.figAmmount = 0;
            FigureLRevers.figAmmount = 0;
            FigurePedustal.figAmmount = 0;
            FigureSquare.figAmmount = 0;
            FigureStick.figAmmount = 0;

            SetTimer();
        }

        public void SetTimer()
        {
            stepTimer = new System.Timers.Timer();
            stepTimer.Interval = level.GetTimerInterval();
            stepTimer.Elapsed += StepTimer_Elapsed;
            stepTimer.Start();
        }

        private void StepTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (gameField.figure == null)
            {
                points += 500 + delLinesAm;
                CurrentFigure = null;
                CurrentFigure = NextFigure;
                NextFigure = GetRandomFigure();
                gameField.AddFigure(CurrentFigure);
                showField.AddFigure(NextFigure);

                if (CheckGameEnd())
                {
                    StopGame();
                    return;

                }

                showField.RedrawField();
            }
            else
            {
                gameField.figure.MoveDown();

                if (!gameField.CheckStop())
                    gameField.MakeARippleForBonusSquare((int)stepTimer.Interval);
            }

            CountPointsAndDelLines();
            CheckLevelUp();
            gameField.RenewInf();
        }

        public void CheckLevelUp()
        {
            if (delLinesAm / 2 - 1 < level.level)
                return;

            level.LevelUp();
            stepTimer.Interval = level.GetTimerInterval();
        }

        public bool CheckGameEnd()
        {
            if (!gameField.cells[gameField.figure.mainCell.x][gameField.figure.mainCell.y].isClear)
                return true;

            foreach (Cell cell in gameField.figure.notMainCells)
            {
                if (!gameField.cells[cell.x][cell.y].isClear)
                    return true;
            }

            return false;
        }

        public Figure GetRandomFigure()
        {
            Random r = new Random();
            int randNum = r.Next(0, figureTypes.Count + 1);
            int counter = 0;
            Type type = typeof(Figure);
            foreach (Type t in figureTypes)
            {
                if (counter == randNum)
                    type = t;
                counter++;
            }

            Figure figure;
            if (type == typeof(FigureSquare))
            {
                Random r2 = new Random();
                if (r.Next(0, 3) == 1)
                    figure = new FigureSquareBonus();
                else
                    figure = new FigureSquare();
            }
            else if (type == typeof(FigureLRevers))
                figure = new FigureLRevers();
            else if (type == typeof(FigureL))
                figure = new FigureL();
            else if (type == typeof(FigureStick))
                figure = new FigureStick();
            else if (type == typeof(FigureCaterparral_L))
                figure = new FigureCaterparral_L();
            else if (type == typeof(FigureCaterparral_R))
                figure = new FigureCaterparral_R();
            else
                figure = new FigurePedustal();
            return figure;

        }

        public void CountPointsAndDelLines()
        {
            int currentAm = gameField.DelFilledLinesAndGetLinesAmount();
            delLinesAm += currentAm;
            points += currentAm * (24 + 2 * delLinesAm);
        }

        public void PauseGame()
        {
            if (stepTimer == null) 
                return;

            if (stepTimer.Enabled)
                stepTimer.Stop();
            else
                stepTimer.Start();
        }

        public void StopGame()
        {
            stepTimer.Stop();
            stepTimer.Enabled = false;
        }
    }

    public enum GameFieldParms : int
    {
        Width = 12,
        Height = 18,
        StartCellX = 4,
        StartCellY = 0,
        X = 560,
        Y = 220,
        cellSide = 30
    }

    public enum ShowFieldParms : int
    {
        Width = 6,
        Height = 6,
        StartCellX = 2,
        StartCellY = 2,
        X = 1080,
        Y = 430,
        cellSide = 30
    }

    public enum StatisticFieldParms : int
    {
        Width = 13,
        Height = 23,
        StartCellX = 5,
        StartCellY = 2,
        X = 80,
        Y = 310,
        cellSide = 20
    }
}
