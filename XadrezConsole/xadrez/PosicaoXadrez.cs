using System;
using XadrezConsole.tabuleiro;

namespace XadrezConsole.xadrez
{
    internal class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            // O uso das aspas é para forçar o retorno em string
            return "" + coluna + linha; 
        }
    }
}
