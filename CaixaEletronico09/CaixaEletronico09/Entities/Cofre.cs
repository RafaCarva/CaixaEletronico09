using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09.Entities
{
    public sealed class Cofre
    {
        public int totalNotas10 { get; set; }
        public int totalNotas20 { get; set; }
        public int totalNotas50 { get; set; }
        public int totalCofre {
            get {
                return (totalNotas10 * 10)
                  + (totalNotas20 * 20)
                  + (totalNotas50 * 50); }
            set { totalCofre = value; }
        }

        public Cofre()
        {
            totalNotas10 = 0;
            totalNotas20 = 0;
            totalNotas50 = 0;
            totalCofre = 0;
        }

        /// <summary>
        /// Formatação do print para opção de exibir o total de notas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "==========SALDO DO CAIXA==========\n"
                + "Notas de 10: " + totalNotas10 + " unidades\n"
                + "Notas de 20: " + totalNotas20 + " unidades\n"
                + "Notas de 50: " + totalNotas50 + " unidades\n"
                + "Total de dinheiro no caixa: R$"+totalCofre+",00";

        }
    }
}
