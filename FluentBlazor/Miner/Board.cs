using System.Drawing;

namespace FluentBlazor.Miner
{
    public class Board
    {
        private readonly Cell[,] _data;

        public Board(int size)
        {
            _data = new Cell[size, size];
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    _data[i, j] = new Cell();
                }
            }

            PlaceBombs();
        }

        public int Columns => _data.GetLength(0);

        public int Rows => _data.GetLength(1);

        public void Init()
        {
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    _data[i, j].Reset();
                }
            }

            PlaceBombs();

            // temporary code 
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    CalculateBombsAround(i, j);
                }
            }
        }

        public Cell this[int x, int y] => _data[x, y];

        private void PlaceBombs()
        {
            var random = new Random();
            var len = _data.GetLength(0);
            var totalBombs = len * len / 5;
            while (totalBombs > 0)
            {
                var x = random.Next(0, len);
                var y = random.Next(0, len);
                if (!_data[x, y].HasBomb)
                {
                    _data[x, y].HasBomb = true;
                    totalBombs--;
                }
            }
        }

        private void CalculateBombsAround(int x, int y)
        {
            var result = -1;
            if (!this[x, y].HasBomb)
            {
                result = 0;
                for (int i = x - 1; i < x + 2; i++)
                {
                    if (i < 0 || i >= Columns) continue;

                    for (int j = y - 1; j < y + 2; j++)
                    {
                        if (j < 0 || j >= Rows || (i == x && j == y)) continue;

                        if (this[i, j].HasBomb)
                        {
                            result++;
                        }
                    }
                }
            }

            this[x, y].BombsAround = result;
        }
    }
}
