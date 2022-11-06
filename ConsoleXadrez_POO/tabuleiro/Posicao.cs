using System;

namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        //atribui valores para o novo objeto instanciado 
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //converter objeto para string 
        public override string ToString()
        {
            return linha + ", " + coluna;
        }
    }
}
