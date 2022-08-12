using FluentBlazor.Miner;
using Microsoft.AspNetCore.Components;

namespace FluentBlazor.Pages
{
    public partial class Miner : ComponentBase
    {
        private Board _board = new Board(5);

        public Board Board => _board;

        private void NewGame()
        {
            _board.Init();
        }
    }
}
