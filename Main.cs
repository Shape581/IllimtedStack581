using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Life;

namespace IllimitedStack581
{
    public class Main : Plugin
    {
        public Main(IGameAPI api) : base(api) { }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[IllmitedStack581] Succes - Initialisé !");
            Console.ResetColor();
            foreach (var elements in Nova.man.item.items)
            {
                elements.maxSlotCount = 999999999;
                elements.isStackable = true;
            }
        }
    }
}
