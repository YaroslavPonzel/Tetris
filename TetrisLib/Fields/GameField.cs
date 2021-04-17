using System.Collections.Generic;

namespace TetrisLib
{
    public class GameField : Field
    {
        public GameField()
            : base((int)GameFieldParms.Width, (int)GameFieldParms.Height, (int)GameFieldParms.StartCellX, (int)GameFieldParms.StartCellY)
        {

        }

        public bool CheckTheFillOfTheLine(int numerOfLine)
        {
            int counter = 0;
            bool res = false;
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i][numerOfLine].isClear)
                    return false;
                else
                    counter++;
            }

            if (counter == cells.Length)
                res = true;

            return res;
        }

        public List<int> GetFilledLines()
        {
            List<int> resList = new List<int>();
            for (int i = 0; i < cells[0].Length; i++)
            {
                if (CheckTheFillOfTheLine(i))
                    resList.Add(i);
            }
            return resList;
        }

        public int DelFilledLinesAndGetLinesAmount()
        {
            List<int> linesList = GetFilledLines();
            foreach (int num in linesList)
            {
                for (int i = 0; i < cells.Length; i++)
                {
                    cells[i][num].Clean();
                    for (int j = num - 1; j >= 0; j--)
                    {
                        if (cells[i][j].isClear)
                            continue;

                        cells[i][j + 1].FillUp(cells[i][j].color);
                        cells[i][j].Clean();
                    }
                }
            }

            return linesList.Count;
        }

        public void HighlightLines(List<int> list, int _interval)
        {
            if (list.Count == 0)
                return;

            int interval = (_interval / 5) - 5;
            RGBColor[][] colorArrs = new RGBColor[list.Count][];

            void FillArr()
            {
                int k = 0;
                foreach (int num in list)
                {
                    colorArrs[k] = new RGBColor[cells.Length];
                    for (int i = 0; i < cells.Length; i++)
                    {
                        colorArrs[k][i] = cells[i][num].color;
                    }
                    k++;
                }
            }

            void SetWhite()
            {
                int k = 0;
                foreach (int num in list)
                {
                    for (int i = 0; i < cells.Length; i++)
                    {
                        cells[i][num].Paint(new RGBColor(255, 255, 255));
                    }
                    k++;
                }

                System.Threading.Thread.Sleep(interval);
            }

            void SetMulticolored()
            {
                int k = 0;
                foreach (int num in list)
                {
                    for (int i = 0; i < cells.Length; i++)
                    {
                        cells[i][num].Paint(colorArrs[k][i]);
                    }
                    k++;
                }
                System.Threading.Thread.Sleep(interval);
            }

            FillArr();
            SetWhite();
            SetMulticolored();
            SetWhite();
            SetMulticolored();
            SetWhite();
        }

        public void HighlightBonusSquare(int _interval)
        {

            if (figure.figureType != "BonusSquare" || !((FigureSquareBonus)figure).isStopped)
                return;


            void SetColor(RGBColor color, int sleepInterval)
            {
                figure.Paint(color);
                RedrawField();
                System.Threading.Thread.Sleep(sleepInterval);
            }

            void Clean()
            {
                figure.Paint(Game.transparentColor);
                RedrawField();
            }

            int interval = (_interval / 5) - 15;

            SetColor(new RGBColor(255, 255, 255), interval);
            SetColor(new FigureSquareBonus().color, interval);
            SetColor(new RGBColor(255, 255, 255), interval);
            SetColor(new FigureSquareBonus().color, interval);
            SetColor(new RGBColor(255, 255, 255), interval);
            Clean();
        }

        public void MakeARippleForBonusSquare(int _interval)
        {
            void SetColor(RGBColor color, int interval)
            {
                figure.Paint(color);
                RedrawField();
                System.Threading.Thread.Sleep(interval);
            }

            if (figure.figureType == "BonusSquare" && !((FigureSquareBonus)figure).isStopped)
            {
                int interval = (int)(_interval / 2) - 15;
                SetColor(new FigureSquareBonus().color, interval);
                SetColor(new RGBColor(60, 180, 60), interval);
            }
        }

        public void RenewInf()
        {
            if (!CheckStop())
            {
                if (figure == null)
                    return;

                if (figure.mainCell.x == startCell.x && figure.mainCell.y == startCell.y)
                    RedrawField();
                else
                    RedrawFieldPart();
            }
            else
                StopFigure();
        }

        public void RedrawFieldPart()
        {
            if (figure == null)
                return;

            int upper;
            int bottom;
            if (figure.mainCell.y - 2 >= 0)
                upper = figure.mainCell.y - 2;
            else
                upper = 0;
            if (figure.mainCell.y + 3 < height)
                bottom = figure.mainCell.y + 3;
            else
                bottom = height;

            for (int i = 0; i < width; i++)
            {
                for (int j = upper; j < bottom; j++)
                {
                    Cell cell = cells[i][j];
                    if (cell.isClear)
                        cell.Clean();

                    if (cell.x == figure.mainCell.x && cell.y == figure.mainCell.y)
                        cell.Paint(figure.color);

                    for (int k = 0; k < figure.notMainCells.Length; k++)
                    {
                        if (cell.x == figure.notMainCells[k].x && cell.y == figure.notMainCells[k].y)
                            cell.Paint(figure.color);
                    }
                }
            }
        }

        public bool CheckStop()
        {
            if (figure == null)
                return false;

            for (int i = 0; i < figure.notMainCells.Length; i++)
            {
                if (figure.notMainCells[i].y == height || !cells[figure.notMainCells[i].x][figure.notMainCells[i].y].isClear)
                {
                    return true;
                }
            }
            if (figure.mainCell.y == height || !cells[figure.mainCell.x][figure.mainCell.y].isClear)
            {
                return true;
            }

            return false;
        }

        public void StopFigure()
        {
            figure.MoveUp();
            figure.figureStopped();
            HighlightBonusSquare((int)Game.stepTimer.Interval);
            RedrawField();
            foreach (Cell[] cellsArr in cells)
            {
                foreach (Cell cell in cellsArr)
                {
                    if (cell.color != Game.transparentColor && cell.isClear)
                        cell.FillUp(figure.color);
                    if (cell.color == Game.transparentColor && !cell.isClear)
                        cell.Clean();
                }
            }

            figure = null;
        }

        public void MoveLeftFigure()
        {
            if (figure != null && figure.mainCell.x > 0 && cells[figure.mainCell.x - 1][figure.mainCell.y].isClear)
            {
                foreach (Cell c in figure.notMainCells)
                {
                    if (c.x <= 0 || !cells[c.x - 1][c.y].isClear)
                        return;
                }
                figure.MoveLeft();
                RedrawField();
            }
        }

        public void MoveRightFigure()
        {
            if (figure != null && figure.mainCell.x < width - 1 && cells[figure.mainCell.x + 1][figure.mainCell.y].isClear)
            {
                foreach (Cell c in figure.notMainCells)
                {
                    if (c.x >= width - 1 || !cells[c.x + 1][c.y].isClear)
                        return;
                }
                figure.MoveRight();
                RedrawField();
            }
        }

        public void MoveDownFigure()
        {
            if (figure != null && figure.mainCell.y < height - 1 && cells[figure.mainCell.x][figure.mainCell.y + 1].isClear)
            {
                foreach (Cell c in figure.notMainCells)
                {
                    if (c.y >= height - 1 || !cells[c.x][c.y + 1].isClear)
                        return;
                }
                figure.MoveDown();
                RedrawField();
            }
        }

        public void MakeTurnFigure()
        {
            if (figure == null)
                return;

            figure.MakeATurn();

            if (figure.mainCell.x < 0 || figure.mainCell.x >= width || figure.mainCell.y < 0 ||
                figure.mainCell.y >= height || !cells[figure.mainCell.x][figure.mainCell.y].isClear)
            {
                figure.MakeATurn(); figure.MakeATurn(); figure.MakeATurn();
            }
            else
            {
                foreach (Cell cell in figure.notMainCells)
                {
                    if (cell.x < 0 || cell.x >= width || cell.y < 0 || cell.y >= height || !cells[cell.x][cell.y].isClear)
                    {
                        figure.MakeATurn(); figure.MakeATurn(); figure.MakeATurn();
                    }
                }
            }

            RedrawField();
        }
    }
}
