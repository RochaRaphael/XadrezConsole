using System;
using XadrezConsole.tabuleiro;

namespace XadrezConsole.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
