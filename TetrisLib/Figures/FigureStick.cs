namespace TetrisLib
{
    public class FigureStick : Figure
    {
        public static int figAmmount = 0;
        private int turnCount = 0;
        public FigureStick() : this(0, 0) { }
        public FigureStick(int x, int y)
            : base(x, y)
        {
            color = new RGBColor(244, 165, 61);
            figureType = "Stick";
            FillInAnArrayOfNonMainCells();
        }

        public override void FillInAnArrayOfNonMainCells()
        {
            notMainCells = new Cell[3];
            int x = mainCell.x;
            int y = mainCell.y;
            notMainCells[0] = new Cell(x + 1, y, color);
            notMainCells[1] = new Cell(x + 2, y, color);
            notMainCells[2] = new Cell(x - 1, y, color);
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
