using Microsoft.AspNetCore.Components;

namespace FluentBlazor.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        private readonly Dictionary<string, string> _menuItems = new()
        {
            { "Home", "/"},
            { "Counter", "/counter"},
            { "Fetch", "/fetchdata"},
            { "Miner", "/miner"},
        };

        public Dictionary<string, string> MenuItems => _menuItems;
    }
}
