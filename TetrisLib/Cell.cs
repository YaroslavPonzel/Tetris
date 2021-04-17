
namespace TetrisLib
{
    public class Cell
    {
        public bool isClear { get; private set; }
        public RGBColor color { get; private set; }
        public int x { get; private set; }
        public int y { get; private set; }

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            isClear = true;
            color = Game.transparentColor;
        }

        public Cell(int x, int y, RGBColor color)
        {
            this.x = x;
            this.y = y;
            isClear = true;
            this.color = color;
        }

        public void Clean()
        {
            isClear = true;
            color = Game.transparentColor;
        }

        public void FillUp(RGBColor color)
        {
            isClear = false;
            this.color = color;

            if (color == Game.transparentColor)
                isClear = true;
        }

        public void Paint(RGBColor color) => this.color = color;

        public void MoveDown() => y++;

        public void MoveRight() => x++;

        public void MoveLeft() => x--;

        public void MoveUp() => y--;

        public void MoveTurn(int x, int y)
        {
            if (x == 1 && y == 1)
            {
                MoveLeft();
                MoveLeft();
                return;
            }
            if (x == 1 && y == 0)
            {
                MoveLeft();
                MoveDown();
                return;
            }
            if (x == 1 && y == -1)
            {
                MoveDown();
                MoveDown();
                return;
            }
            if (x == 0 && y == 1)
            {
                MoveLeft();
                MoveUp();
                return;
            }
            if (x == 0 && y == -1)
            {
                MoveRight();
                MoveDown();
                return;
            }
            if (x == -1 && y == 1)
            {
                MoveUp();
                MoveUp();
                return;
            }
            if (x == -1 && y == 0)
            {
                MoveUp();
                MoveRight();
                return;
            }
            if (x == -1 && y == -1)
            {
                MoveRight();
                MoveRight();
                return;
            }
            if (x == 2 && y == 0)
            {
                MoveLeft();
                MoveLeft();
                MoveDown();
                MoveDown();
                return;
            }
            if (x == 0 && y == 2)
            {
                MoveLeft();
                MoveLeft();
                MoveUp();
                MoveUp();
                return;
            }
            if (x == -2 && y == 0)
            {
                MoveUp();
                MoveUp();
                MoveRight();
                MoveRight();
                return;
            }
            if (x == 0 && y == -2)
            {
                MoveRight();
                MoveRight();
                MoveDown();
                MoveDown();
                return;
            }
        }
    }
}
