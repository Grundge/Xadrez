using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using XadrezAulas.Controllers;
using XadrezAulas.Models;

namespace XadrezAulas.Views
{
    public class Jogo
    {
        private TabuleiroController _tabuleiroController;
        private EstadoJogo _estadoJogo;

        public Jogo()
        {
            _tabuleiroController = new TabuleiroController();
            _estadoJogo = EstadoJogo.InscreverJogadores;
            Console.WriteLine("Bem vindo ao jogo de xadrez");
            Console.WriteLine("Iremos processar a inscrição dos jogadores");
        }

        public void InicializarJogo()
        {
            while (_estadoJogo != EstadoJogo.FimJogo)
            {
                switch (_estadoJogo)
                {
                    case EstadoJogo.InscreverJogadores:
                        Console.WriteLine("Jogador {0} introduza o seu nome", _tabuleiroController.JogadoresInscritos() + 1);
                        string nome = Console.ReadLine();
                        _tabuleiroController.InscreverJogador(nome);
                        if (_tabuleiroController.JogadoresInscritos() == 2)
                        {
                            _estadoJogo = EstadoJogo.Jogar;
                        }
                        break;
                    case EstadoJogo.Jogar:

                        break;
                    case EstadoJogo.FimJogo:
                        break;
                }
            }
        }
    }
}
