namespace TetrisLib
{
    public class StatisticField : Field
    {
        private Figure[] figures = new Figure[7] { new FigureCaterparral_L(4, 2), new FigureCaterparral_R(4, 5), new FigureL(4, 8),
            new FigureLRevers(4, 11), new FigurePedustal(4, 14),new FigureSquare(4, 17), new FigureStick(3, 20)};
        public StatisticField() 
            :base((int)StatisticFieldParms.Width, (int)StatisticFieldParms.Height, 
                 (int)StatisticFieldParms.StartCellX, (int)StatisticFieldParms.StartCellY)
        {
            RedrawField();
        }

        public override void RedrawField()
        {
            foreach (Figure figure in figures)
            {
                cells[figure.mainCell.x][figure.mainCell.y].Paint(figure.color);
                foreach (Cell cell in figure.notMainCells)
                {
                    cells[cell.x][cell.y].Paint(figure.color);
                }
            }
        }
    }
}
