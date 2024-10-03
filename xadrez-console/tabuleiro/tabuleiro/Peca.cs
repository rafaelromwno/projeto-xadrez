using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro.Enums;

namespace xadrez_console.tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QuantidadeMovimentos = 0;
        }
    }
}
