using Microsoft.AspNetCore.Components;

namespace FluentBlazor.Pages
{
    public partial class Miner : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
