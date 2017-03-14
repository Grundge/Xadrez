using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezAulas.Models;

namespace XadrezAulas.Controllers
{
    public class TabuleiroController
    {
        private Tabuleiro _tabuleiro;
        public TabuleiroController()
        {
            _tabuleiro = new Tabuleiro();
        }

        public void InscreverJogador(string nome)
        {
            Jogador jogador = new Jogador(nome, (CorPeca)(JogadoresInscritos()));
            _tabuleiro.JogadorList.Add(jogador);
        }

        public int JogadoresInscritos()
        {
            return _tabuleiro.JogadorList.Count();
        }

        public void TrocarTurno()
        {
            
        }
    }
}
