namespace TetrisLib
{
    public class Level
    {
        public int level { get; private set; }

        public Level() : this(0) { }

        public Level(int level) => this.level = level;

        public void LevelUp() => level++;

        public int GetTimerInterval() => 534 - level * 15;
    }
}
