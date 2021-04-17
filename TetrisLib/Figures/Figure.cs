namespace TetrisLib
{
    public abstract class Figure
    {
        public RGBColor color { get; protected set; }
        public Cell mainCell { get; protected set; }
        public Cell[] notMainCells { get; protected set; }
        public string figureType { get; protected set; }

        public Figure(int x, int y)
        {
            mainCell = new Cell(x, y, color);
        }

        public abstract void FillInAnArrayOfNonMainCells();

        public void Paint(RGBColor color) => this.color = color;

        public void MoveDown()
        {
            for (int I = 0; I < notMainCells.Length; I++)
            {
                notMainCells[I].MoveDown();
            }
            mainCell.MoveDown();
        }

        public void MoveUp()
        {
            for (int I = 0; I < notMainCells.Length; I++)
            {
                notMainCells[I].MoveUp();
            }
            mainCell.MoveUp();
        }

        public void MoveRight()
        {
            for (int I = 0; I < notMainCells.Length; I++)
            {
                notMainCells[I].MoveRight();
            }
            mainCell.MoveRight();
        }

        public void MoveLeft()
        {
            for (int I = 0; I < notMainCells.Length; I++)
            {
                notMainCells[I].MoveLeft();
            }
            mainCell.MoveLeft();
        }

        public virtual void MakeATurn()
        {
            foreach (Cell cell in notMainCells)
            {
                int x = cell.x - mainCell.x;
                int y = cell.y - mainCell.y;
                cell.MoveTurn(x, y);
            }
        }

        public abstract void figureStopped();
    }
}
