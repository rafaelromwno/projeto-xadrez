using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    public class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Pecas = new Peca[linha, coluna];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }
}
