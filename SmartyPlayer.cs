using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class SmartyPlayer : Player
    {
        List<char> alphabet = new List<char>() { 'e', 't', 'a', 'o', 'i', 'n', 's', 'r', 'h', 'l', 'd', 'c', 'u',
        'm', 'f', 'p', 'g', 'w', 'y', 'b', 'v', 'k', 'x', 'j', 'q', 'z'};

        public override char Guess()
        {
            char guess = alphabet[0];
            alphabet.Remove(guess);
            return guess;
        }
    }
}
