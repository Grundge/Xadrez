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

        public List<Jogador> GetListaJogadores()
        {
            return _tabuleiro.JogadorList;
        }

        public void TrocarTurno()
        {
            // todo: Trocar os turnos dos jogadores
            int posicao = _tabuleiro.JogadorList.IndexOf(_tabuleiro.JogadorList.FirstOrDefault(j => j.TurnoJogar == true));
            _tabuleiro.JogadorList.FirstOrDefault(j => j.TurnoJogar == false).TurnoJogar = true;
            _tabuleiro.JogadorList[posicao].TurnoJogar = false;
            foreach (Jogador jogador in _tabuleiro.JogadorList)
            {
                Console.WriteLine(jogador.TurnoJogar);
            }
        }
    }
}
