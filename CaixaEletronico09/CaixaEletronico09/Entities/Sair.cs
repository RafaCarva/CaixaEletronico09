using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09.Entities
{
    class Sair : ISair
    {
        /// <summary>
        /// Sai da aplicação.
        /// </summary>
        void ISair.Sair()
        {
            System.Environment.Exit(-1);
        }
    }
}
