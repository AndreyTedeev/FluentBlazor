using System.Drawing;

namespace FluentBlazor.Miner
{
    public class Board
    {
        private readonly Cell[,] _data;

        public Board(int size)
        {
            _data = new Cell[size, size];
            Init();
        }

        public int Columns => _data.GetLength(0);

        public int Rows => _data.GetLength(1);

        public void Init()
        {
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    _data[i, j] = new Cell();
                }
            }

            PlaceBombs();
        }

        public Cell this[int x, int y]
        {
            get => _data[x, y];
            set => _data[x, y] = value;
        }

        private void PlaceBombs()
        {
            var random = new Random();
            var len = _data.GetLength(0);
            var bombCount = len * len / 3;
            while (bombCount > 0)
            {
                var x = random.Next(0, len - 1);
                var y = random.Next(0, len - 1);
                if (!_data[x, y].HasBomb) 
                {
                    _data[x, y].HasBomb = true;
                    bombCount--;
                }
            }
        }
    }
}
