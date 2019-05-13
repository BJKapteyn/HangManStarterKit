using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new ABCplayer();
            Player ranP = new RandomPlayer();
            Player bruteP = new BruteForcePlayer();
            TenGames playTen = new TenGames(bruteP);
            TenGames playTen1 = new TenGames(bruteP);
            Console.ReadKey();
            AutoHangMan auto = new AutoHangMan(ranP);
            Console.ReadKey();
            //HangmanGame ran = new HangmanGame(ranP);
            //HangmanGame brute = new HangmanGame(bruteP);
            HumanPlayer p2 = new HumanPlayer();
            //Need to add in how to handle multi letter words like apple
            HangmanGame hg = new HangmanGame(p2, "apple");
        }
    }
}
