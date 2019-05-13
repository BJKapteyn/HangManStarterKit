using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class TenGames
    {
        Player Player { get; set; }
        public TenGames(Player player)
        {
            Player = player;
            RunGames();
        }

        public int RunGames()
        {
            int tries = 0;
            for (int i = 0; i < 10; i++)
            {
                AutoHangMan auto = new AutoHangMan(Player);
                tries += auto.tries;
            }
            Console.WriteLine($"you took {tries} tries in ten games.");
            return tries;
        }
    }
}
