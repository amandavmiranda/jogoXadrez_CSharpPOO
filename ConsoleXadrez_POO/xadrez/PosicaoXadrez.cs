using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        //Converter a posicao do xadrez para uma posicao interna de matriz 
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');//a-a = 0 
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
