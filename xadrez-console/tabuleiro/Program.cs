﻿using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;



namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
