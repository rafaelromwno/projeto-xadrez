using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linhas = linha;
            Colunas = coluna;
            Pecas = new Peca[linha, coluna];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca GetPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return GetPeca(pos) != null;
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }

            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;

        }

        public Peca RetirarPeca(Posicao pos)
        {
            if(GetPeca(pos) == null)
            {
                return null;
            }
            Peca aux = GetPeca(pos);
            aux.Posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    }
}
