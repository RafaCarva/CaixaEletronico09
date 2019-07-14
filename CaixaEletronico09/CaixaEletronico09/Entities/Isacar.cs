using CaixaEletronico09.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09
{
    interface ISacar
    {
        /// <summary>
        /// A classe concreta instancia um objeto do tipo Cofre
        /// para enviar junto com o valor a ser descontao do total.
        /// </summary>
        /// <param name="cofre"></param>
        /// <param name="valor"></param>
        void sacarDinheiro(Cofre cofre, int valor);
    }
}
