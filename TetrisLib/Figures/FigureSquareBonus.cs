namespace TetrisLib
{
    public class FigureSquareBonus : FigureSquare
    {
        public bool isStopped { get; private set; } = false;
        public FigureSquareBonus() : this(0, 0) { }
        public FigureSquareBonus(int x, int y)
            : base(x, y)
        {
            color = new RGBColor(250, 100, 100);
            figureType = "BonusSquare";
        }

        public override void figureStopped()
        {
            EditAnArrayOfNonMainCells();
            color = Game.transparentColor;
            figAmmount++;
            isStopped = true;
        }

        private void EditAnArrayOfNonMainCells()
        {
            notMainCells = new Cell[15];
            int x = mainCell.x;
            int y = mainCell.y;
            notMainCells[0] = new Cell(x + 1, y, color);
            notMainCells[1] = new Cell(x + 1, y + 1, color);
            notMainCells[2] = new Cell(x, y + 1, color);
            notMainCells[3] = new Cell(x - 1, y - 1, color);
            notMainCells[4] = new Cell(x, y - 1, color);
            notMainCells[5] = new Cell(x + 1, y - 1, color);
            notMainCells[6] = new Cell(x + 2, y - 1, color);
            notMainCells[7] = new Cell(x - 1, y, color);
            notMainCells[8] = new Cell(x + 2, y, color);
            notMainCells[9] = new Cell(x - 1, y + 1, color);
            notMainCells[10] = new Cell(x + 2, y + 1, color);
            notMainCells[11] = new Cell(x - 1, y + 2, color);
            notMainCells[12] = new Cell(x, y + 2, color);
            notMainCells[13] = new Cell(x + 1, y + 2, color);
            notMainCells[14] = new Cell(x + 2, y + 2, color);
        }
    }
}
