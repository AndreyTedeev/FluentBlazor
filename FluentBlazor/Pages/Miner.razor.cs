using FluentBlazor.Miner;
using Microsoft.AspNetCore.Components;

namespace FluentBlazor.Pages
{
    public partial class Miner : ComponentBase
    {
        private Board _board = new Board(10);

        private void NewGame()
        {
            _board.Init();
        }

    }
}
