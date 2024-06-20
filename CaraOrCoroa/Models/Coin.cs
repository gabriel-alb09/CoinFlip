using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraOrCoroa.Models
{
    class Coin
    {
        public string Lado { get; set; }
        public string Jogar(string ladoEscolhido)
        {
            int LadoSorteado = new Random().Next(2);
            Lado = LadoSorteado == 0 ? "CARA" : "COROA";
            string resultado = Lado == ladoEscolhido ?
                $"Parabéns, você pediu {ladoEscolhido} e deu {Lado} " :
                $"Que pena! Você pediu {ladoEscolhido} e deu {Lado}";
            return (resultado);
        }

    }
}
