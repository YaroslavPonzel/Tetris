namespace TetrisLib
{
    public class FigureSquare : Figure
    {
        public static int figAmmount = 0;
        public FigureSquare() : this(0, 0) { }
        public FigureSquare(int x, int y)
            : base(x, y)
        {
            color = new RGBColor(255, 56, 56);
            figureType = "Square";
            FillInAnArrayOfNonMainCells();
        }

        public override void FillInAnArrayOfNonMainCells()
        {
            notMainCells = new Cell[3];
            int x = mainCell.x;
            int y = mainCell.y;
            notMainCells[0] = new Cell(x + 1, y, color);
            notMainCells[1] = new Cell(x + 1, y + 1, color);
            notMainCells[2] = new Cell(x, y + 1, color);
        }

        public override void figureStopped() => figAmmount++;

        public override void MakeATurn() { }
    }
}
