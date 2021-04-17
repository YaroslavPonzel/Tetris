namespace TetrisLib
{
    public class FigurePedustal : Figure
    {
        public static int figAmmount = 0;

        public FigurePedustal() : this(0, 0) { }
        public FigurePedustal(int x, int y)
            : base(x, y)
        {
            color = new RGBColor(255, 251, 61);
            figureType = "Pedustal";
            FillInAnArrayOfNonMainCells();
        }

        public override void FillInAnArrayOfNonMainCells()
        {
            notMainCells = new Cell[3];
            int x = mainCell.x;
            int y = mainCell.y;
            notMainCells[0] = new Cell(x + 1, y, color);
            notMainCells[1] = new Cell(x, y + 1, color);
            notMainCells[2] = new Cell(x - 1, y, color);
        }

        public override void figureStopped() => figAmmount++;
    }
}
