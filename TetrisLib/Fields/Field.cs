using System;

namespace TetrisLib
{
    public abstract class Field
    {
        public Cell[][] cells { get; private set; }
        public Cell startCell { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }
        public Figure figure { get; set; }

        public Field(int width, int height, int startCellI, int startCellJ)
        {
            this.width = width;
            this.height = height;

            cells = new Cell[width][];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell[height];
                for (int j = 0; j < cells[i].Length; j++)
                {
                    cells[i][j] = new Cell(i, j);
                }
            }
            startCell = cells[startCellI][startCellJ];
        }

        public void AddFigure(Figure newFigure)
        {

            figure = newFigure;
            int right = startCell.x - figure.mainCell.x;
            int down = startCell.y - figure.mainCell.y;
            if (right > 0)
            {
                for (int i = 0; i < right; i++)
                {
                    figure.MoveRight();
                }
            }
            else if (right < 0)
            {
                for (int i = 0; i < Math.Abs(right); i++)
                {
                    figure.MoveLeft();
                }
            }

            if (down > 0)
            {
                for (int i = 0; i < down; i++)
                {
                    figure.MoveDown();
                }
            }
            else if (down < 0)
            {
                for (int i = 0; i < Math.Abs(down); i++)
                {
                    figure.MoveUp();
                }
            }
        }

        public virtual void RedrawField()
        {
            if (figure == null) 
                return;

            foreach (Cell[] cellsArr in cells)
            {
                foreach (Cell cell in cellsArr)
                {
                    if (cell.isClear)
                        cell.Clean();
                    if (cell.x == figure.mainCell.x && cell.y == figure.mainCell.y)
                        cell.Paint(figure.color);

                    if (figure == null) 
                        return;

                    for (int i = 0; i < figure.notMainCells.Length; i++)
                    {
                        if (cell.x == figure.notMainCells[i].x && cell.y == figure.notMainCells[i].y)
                            cell.Paint(figure.color);
                    }
                }
            }
        }

    }
}
