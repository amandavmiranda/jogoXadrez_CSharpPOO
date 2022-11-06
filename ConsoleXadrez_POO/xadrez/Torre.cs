using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        //Repassando de outro construtor para esse
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima da posicao da torre
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //parar quando bater em uma peça adversária
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //próxima posicao acima 
                pos.linha = pos.linha - 1;
            }

            //abaixo da posicao da torre
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //parar quando bater em uma peça adversária
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //próxima posicao acima 
                pos.linha = pos.linha + 1;
            }

            //direita da posicao da torre
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //parar quando bater em uma peça adversária
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //próxima posicao acima 
                pos.coluna = pos.coluna + 1;
            }

            //esquerda da posicao da torre
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                //parar quando bater em uma peça adversária
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //próxima posicao acima 
                pos.coluna = pos.coluna - 1;
            }

            return mat;
        }
    }
}
