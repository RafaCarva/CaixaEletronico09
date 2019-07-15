using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09.Entities
{
    public sealed class Carregar : ICarregar
    {
        public Carregar()
        {
        }

        /// <summary>
        /// A instância do cofre recebido estará zerada, e será devolvida com
        /// o valor atualizado.
        /// </summary>
        /// <param name="cofre"></param>
        /// <param name="nota"></param>
        /// <param name="quantidade"></param>
        /// <returns>O retorno será a instância "atual" do cofre</returns>
        public Cofre CarregaCaixa(Cofre cofre, int nota, int quantidade)
        {
            switch (nota)
            {
                case 10:
                    cofre.totalNotas10 += quantidade;
                    cofre.totalCofre += quantidade * 10;
                    break;
                case 20:
                    cofre.totalNotas20 += quantidade;
                    cofre.totalCofre += quantidade * 20;
                    break;
                case 50:
                    cofre.totalNotas50 += quantidade;
                    cofre.totalCofre += quantidade * 50;
                    break;
                default:
                    Console.Write("O valor é inaceitável;");
                    break;
            }
            return cofre;
        }
    }
}
