using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezAulas.Models
{
    public class Peca
    {
        public Peca(TipoPeca tipoPeca, Posicao posicao, CorPeca corPeca)
        {
            TipoPeca = tipoPeca;
            Posicao = posicao;
            CorPeca = corPeca;
        }
        public TipoPeca TipoPeca { get; set; }
        public Posicao Posicao { get; set; }
        public CorPeca CorPeca { get; set; }
    }
}
