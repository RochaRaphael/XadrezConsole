namespace XadrezConsole.tabuleiro
{
    internal class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            linha = linha;
            coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }

    }
}
