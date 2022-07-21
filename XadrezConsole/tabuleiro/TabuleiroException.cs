using System;

namespace XadrezConsole.tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
            {
            }
    }
}
