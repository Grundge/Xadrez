using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezAulas.Models;
using XadrezAulas.Views;

namespace XadrezAulas
{
    class Program
    {
        static void Main(string[] args)
        {
            char teste = 'H';
            teste = Char.ToLower(teste);
            /*>= 97  <= 104*/
            /* 0 a 7 */
            //Console.WriteLine((int)teste);
            Console.ReadKey();
            Jogo jogo = new Jogo();
            jogo.InicializarJogo();
        }
    }
}
