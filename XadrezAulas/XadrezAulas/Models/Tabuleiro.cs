using System.Collections.Generic;

namespace XadrezAulas.Models
{
    public class Tabuleiro
    {
        public Tabuleiro()
        {
            PecasList = new List<Peca>()
            {
                new Peca(TipoPeca.Peao, new Posicao(0,'b'), CorPeca.Branco),
                new Peca(TipoPeca.Peao, new Posicao(1,'b'), CorPeca.Branco),
                new Peca(TipoPeca.Peao, new Posicao(2,'b'), CorPeca.Branco),
                new Peca(TipoPeca.Peao, new Posicao(3,'b'), CorPeca.Branco),
                new Peca(TipoPeca.Peao, new Posicao(4,'b'), CorPeca.Branco),
                new Peca(TipoPeca.Peao, new Posicao(5,'b'), CorPeca.Branco),
                new Peca(TipoPeca.Peao, new Posicao(6,'b'), CorPeca.Branco),
                new Peca(TipoPeca.Peao, new Posicao(7,'b'), CorPeca.Branco),

                new Peca(TipoPeca.Peao, new Posicao(0,'g'), CorPeca.Preto),
                new Peca(TipoPeca.Peao, new Posicao(1,'g'), CorPeca.Preto),
                new Peca(TipoPeca.Peao, new Posicao(2,'g'), CorPeca.Preto),
                new Peca(TipoPeca.Peao, new Posicao(3,'g'), CorPeca.Preto),
                new Peca(TipoPeca.Peao, new Posicao(4,'g'), CorPeca.Preto),
                new Peca(TipoPeca.Peao, new Posicao(5,'g'), CorPeca.Preto),
                new Peca(TipoPeca.Peao, new Posicao(6,'g'), CorPeca.Preto),
                new Peca(TipoPeca.Peao, new Posicao(7,'g'), CorPeca.Preto),
            };

            JogadorList =new List<Jogador>();
        }

        public List<Peca> PecasList { get; set; }
        public List<Jogador> JogadorList { get; set; }

    }
}
