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
                            _tabuleiroController.GetListaJogadores().FirstOrDefault().TurnoJogar = true;
                        }
                        break;
                    case EstadoJogo.Jogar:
                        Console.WriteLine("É a vez do jogador {0} jogar\n", 
                            _tabuleiroController.GetListaJogadores().FirstOrDefault(j => j.TurnoJogar = true).Nome);
                        Console.Write("Indique a linha onde quer jogar (a - h) ");
                        ConsoleKeyInfo consoleKeyInfoLine = Console.ReadKey();
                        // todo: validar linha
                        Console.Write("Indique a coluna onde quer jogar (0 - 7) ");
                        ConsoleKeyInfo consoleKeyInfoColumn = Console.ReadKey();
                        // todo: validar coluna
                        // todo: validar possíveis posições das peças
                        // todo: validar possíveis movimentos dos jogadores
                        _tabuleiroController.TrocarTurno();
                        break;
                    case EstadoJogo.FimJogo:
                        break;
                }
            }
        }
    }
}
