using System;

namespace TetrisLib
{
    public class FigureCaterparral_L : Figure
    {
        public static int figAmmount = 0;

        private int turnCount = 0;
        public FigureCaterparral_L() : this(0, 0) { }
        public FigureCaterparral_L(int x, int y)
            : base(x, y)
        {
            color = new RGBColor(25, 105, 198);
            figureType = "Caterparral-L";
            FillInAnArrayOfNonMainCells();
        }

        public override void FillInAnArrayOfNonMainCells()
        {
            notMainCells = new Cell[3];
            int x = mainCell.x;
            int y = mainCell.y;
            notMainCells[0] = new Cell(x - 1, y, color);
            notMainCells[1] = new Cell(x, y + 1, color);
            notMainCells[2] = new Cell(x + 1, y + 1, color);
        }

        public override void figureStopped() => figAmmount++;

        public override void MakeATurn()
        {
            if (turnCount % 2 == 0)
            {
                foreach (Cell cell in notMainCells)
                {
                    int x = cell.x - mainCell.x;
                    int y = cell.y - mainCell.y;
                    cell.MoveTurn(x, y);
                }
            }
            else if (turnCount % 2 == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    foreach (Cell cell in notMainCells)
                    {
                        int x = cell.x - mainCell.x;
                        int y = cell.y - mainCell.y;
                        cell.MoveTurn(x, y);
                    }
                }
            }
            turnCount++;
        }
    }
}
