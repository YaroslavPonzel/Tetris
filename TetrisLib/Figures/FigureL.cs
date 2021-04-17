﻿namespace TetrisLib
{
    public class FigureL : Figure
    {
        public static int figAmmount = 0;
        public FigureL() : this(0, 0) { }
        public FigureL(int x, int y)
            : base(x, y)
        {
            color = new RGBColor(196, 25, 198);
            figureType = "L";
            FillInAnArrayOfNonMainCells();
        }

        public override void figureStopped()
        {
            figAmmount++;
        }

        public override void FillInAnArrayOfNonMainCells()
        {
            notMainCells = new Cell[3];
            int x = mainCell.x;
            int y = mainCell.y;
            notMainCells[0] = new Cell(x + 1, y, color);
            notMainCells[1] = new Cell(x - 1, y + 1, color);
            notMainCells[2] = new Cell(x - 1, y, color);
        }
    }
}
