namespace FluentBlazor.Miner
{
    public class Cell
    {
        public bool HasBomb { get; set; } = false;

        public bool IsOpen { get; set; } = false;

        // Count of bombs around the cell.
        public int BombsAround { get; set; } = 0;

        public void Reset() 
        {
            HasBomb = false;
            IsOpen = false;
            BombsAround = 0;
        }
    }
}
