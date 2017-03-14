using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezAulas.Models
{
    public class Jogador
    {
        public Jogador(string nome, CorPeca corPeca)
        {
            Nome = nome;
            CorPeca = corPeca;
        }

        public string Nome { get; set; }
        public CorPeca CorPeca { get; set; }
        //public List<Jogadas> Criar modelo de jogadas
    }
}
