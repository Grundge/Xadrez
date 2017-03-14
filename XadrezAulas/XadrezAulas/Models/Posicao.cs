using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezAulas.Models
{
    public class Posicao
    {
        public Posicao(int coluna, char linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public int Coluna { get; set; }
        public char Linha { get; set; }

        public static bool operator ==(Posicao p1, Posicao p2)
        {
            return (p1.Linha == p2.Linha && p1.Coluna == p2.Coluna);
        }

        public static bool operator !=(Posicao p1, Posicao p2)
        {
            return !(p1.Linha == p2.Linha && p1.Coluna == p2.Coluna);
        }
    }
}
